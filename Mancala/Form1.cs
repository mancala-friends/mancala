using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mancala
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// This creates the form and starts the player at the Menu tab.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            mancalaTabs.SelectedTab = menuTab;
            mancalaTabs.TabPages.Remove(gameTab);
        }

        private bool hasAI = false;

        private class Pit
        {
            public int Player { get; set; }
            public int Location { get; set; }
        }

        private Dictionary<int, List<PictureBox>> pitPictureBoxes = new Dictionary<int, List<PictureBox>>();
        private Rules rules;

        private List<PictureBox> createPlayerPits(int xPosition, int yPosition, int step, int player)
        {
            var pitImages = new List<PictureBox>();
            for (int i = 0; i < 6; i++)
            {
                var picture = new PictureBox
                {
                    Name = "Pit" + i,
                    Location = new Point((int) (xPosition + i * step), yPosition),
                    Image = Mancala.Properties.Resources.pit,
                    Size = Mancala.Properties.Resources.pit.Size,
                    BackColor = Color.Transparent,
                    Visible = true,
                    Tag = new Pit { Player=player, Location=i}
                };

                picture.MouseClick += pitClicked;

                pitImages.Add(picture);
            }

            return pitImages;
        }

        private void setUpPits(Dictionary<int, List<PictureBox>> playerSides)
        {
            boardBox.Controls.Clear();
            foreach (var side in playerSides)
            {
                foreach (var pit in side.Value)
                {
                    boardBox.Controls.Add(pit);
                }
            }
        }

        private void pitClicked(object sender, MouseEventArgs e)
        {
            Pit pit = (Pit) ((Control) sender).Tag;
            var gameState = rules.getGamestate();
            if (pit.Player == gameState.currentPlayer)
            {
                rules.tryMove(pit.Location);
                render(gameState);
            }
        }

        private PictureBox createPlayerStore(int xPosition, int yPosition, int player)
        {
            PictureBox picture = new PictureBox
            {
                Name = "Store" + player,
                Location = new Point(xPosition, yPosition),
                Image = Mancala.Properties.Resources.store,
                Size = Mancala.Properties.Resources.store.Size,
                BackColor = Color.Transparent,
                Visible = true
            };

            return picture;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPits(object sender, EventArgs e)
        {
            rules = new Rules();
            int boardWidth = Mancala.Properties.Resources.board.Width;
            int pitWidth = Mancala.Properties.Resources.pit.Width;
            int xOffset = 110;
            int p1 = 1;
            int p2 = 2;

            pitPictureBoxes.Clear();            
            pitPictureBoxes[p1] = createPlayerPits(xOffset, 175, Mancala.Properties.Resources.pit.Width + 10, p1);
            pitPictureBoxes[p1].Add(createPlayerStore(boardBox.Width - 100, 20, p1));
            pitPictureBoxes[p2] = createPlayerPits(boardWidth - pitWidth - xOffset, 20, -(pitWidth + 10), p2);
            pitPictureBoxes[p2].Add(createPlayerStore(10, 20, p2));
            setUpPits(pitPictureBoxes);

            render(rules.getGamestate());
        }

        private void AIplay()
        {
            this.Refresh();
            Thread.Sleep(1000);
            Random random = new Random();
            while(rules.getGamestate().currentPlayer == 2 && !rules.getGamestate().isOver())
            {
                rules.tryMove(random.Next(6));
            }

            var gameState = rules.getGamestate();
            render(gameState);
        }

        private void render(GameState gameState)
        {

            render(gameState.playerOne, 1);
            render(gameState.playerTwo, 2);

            if (rules.getGamestate().isOver())
            {
                gameOverScreen gameOverView = new gameOverScreen(rules.getGamestate());
                gameOverView.Show();
                backButton.PerformClick();
                gameOverView.BringToFront();
                return;
            }

            if (gameState.currentPlayer == 1)
            {
                player1Label.Font = new Font("Microsoft Sans Serif",26, FontStyle.Regular);
                player1Label.ForeColor = System.Drawing.Color.Gold;
                player2Label.Font = new Font("Microsoft Sans Serif",20, FontStyle.Regular);
                player2Label.ForeColor = System.Drawing.Color.Black;

            }
            else
            {
                player2Label.Font = new Font("Microsoft Sans Serif", 26, FontStyle.Regular);
                player2Label.ForeColor = System.Drawing.Color.Gold;
                player1Label.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular);
                player1Label.ForeColor = System.Drawing.Color.Black;
                if (hasAI)
                {
                    AIplay();
                }
            }
        }

        private Bitmap colorPick(int chosen)
        {
            switch (chosen)
            {
                case 0:
                    return Mancala.Properties.Resources.pebble_yellow;
                case 1:
                    return Mancala.Properties.Resources.pebble_cyan;
                default:
                    return Mancala.Properties.Resources.pebble_magenta;
            }
        }

        private void determineColor(int oneLayerOfPebbles, ref int chosenColor, ref int pebbleIndex)
        {
            while (pebbleIndex >= oneLayerOfPebbles)
            {
                pebbleIndex -= oneLayerOfPebbles;
                chosenColor = (chosenColor + 1) % 3;
            }
        }

        private int calculatePosition(int slice, int totalSlices, int pebbleLength, int pitLength)
        {
            return slice * (pitLength / totalSlices) + (pitLength / (totalSlices * 2)) - (pebbleLength / 2);
        }

        private Point pebbleLocationInPit(int pebbleIndex, Size pebbleSize, Size paddedPitSize, Size padding, int rows, int columns)
        {
            int row = pebbleIndex / columns;
            int col = pebbleIndex % columns;

            int xpos = calculatePosition(col, columns, pebbleSize.Width, paddedPitSize.Width);
            int ypos = calculatePosition(row, rows, pebbleSize.Height, paddedPitSize.Height);
            return new Point(xpos+padding.Width/2, ypos+padding.Height/2);
        }

        private PictureBox scatterPebble(int pebbleIndex, Size pebbleSize, Size pitSize)
        {
            var padding = new Size(12, 12);
            var paddedPitSize = pitSize - padding;
            int rows = paddedPitSize.Height / pebbleSize.Height;
            int columns = paddedPitSize.Width / pebbleSize.Width;

            int chosenColor = 0;
            determineColor(rows * columns, ref chosenColor, ref pebbleIndex);
            var color = colorPick(chosenColor);

            PictureBox pebble = new PictureBox
            {
                Name = "Pebble",
                Image = color,
                Size = color.Size,
                BackColor = Color.Transparent,
                Visible = true
            };


            pebble.Location = pebbleLocationInPit(pebbleIndex, pebbleSize, paddedPitSize, padding, rows, columns);
            pebble.Size = pebbleSize;
            pebble.MouseClick += Pebble_MouseClick;
            
            return pebble;
        }

        private void render(int[] player, int playerId)
        {
            for(var i = 0; i < player.Length; i++)
            {
                pitPictureBoxes[playerId][i].Controls.Clear();
                for(var j = 0; j < player[i]; j++)
                {
                    var pitPicture = pitPictureBoxes[playerId][i];
                    var pebble = scatterPebble(j, Mancala.Properties.Resources.pebble_yellow.Size, pitPicture.Size);
                    pitPicture.Controls.Add(pebble);
                    pebble.BringToFront();
                }
            }
        }

        private void Pebble_MouseClick(object sender, MouseEventArgs e)
        {
            var pit = (PictureBox) ((PictureBox)sender).Parent;
            pitClicked(pit, e);
        }



        /// <summary>
        /// This function starts a player vs AI version of Mancala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            mancalaTabs.TabPages.Add(gameTab);
            mancalaTabs.SelectedTab = gameTab;
            mancalaTabs.TabPages.Remove(menuTab);

            player2Label.Text = "Player 2 (AI)";
            hasAI = true;
            createPits(sender, e);

            // TODO: Start a one player vs AI game
            createPits(sender, e);

        }

        /// <summary>
        /// This function sends the player into a networked lobby where the player will wait 
        /// for other players to play a game of Mancala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void networkButton_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This function starts a player vs player version of Mancala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void twoPlayerButton_Click(object sender, EventArgs e)
        {
            mancalaTabs.TabPages.Add(gameTab);
            mancalaTabs.SelectedTab = gameTab;
            mancalaTabs.TabPages.Remove(menuTab);

            // TODO: Start a two player game. User vs User

            player2Label.Text = "Player 2";

            hasAI = false;

            //Creates a new game and rules and writes the player turn to the console.
            createPits(sender, e);
            


        }

        /// <summary>
        ///  This function ends the application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Exits the application
        }

        /// <summary>
        /// This function returns the player back to the main menu. The result is that the player forfits the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backButton_Click(object sender, EventArgs e)
        {
            //TODO: End the current game and then go back to main menu
            mancalaTabs.TabPages.Add(menuTab);
            mancalaTabs.SelectedTab = menuTab;
            mancalaTabs.TabPages.Remove(gameTab);

        }

        /// <summary>
        /// This function sends the user to an information page about the game of Mancala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoButton_Click(object sender, EventArgs e)
        {
            infoFrame tutorial = new infoFrame();
            tutorial.Show();
        }


        /// <summary>
        /// This function pops up a window showing the instructions for playing the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void instructionButton_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// This funciton pops up a window showing information about the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutButton_Click(object sender, EventArgs e)
        {
            aboutForm about = new aboutForm();
            about.Show();

        }
    }
}
