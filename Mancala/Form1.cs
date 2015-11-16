using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private class Pit
        {
            public int Player { get; set; }
            public int Location { get; set; }
        }

        private Dictionary<int, List<PictureBox>> pitPictureBoxes = new Dictionary<int, List<PictureBox>>();

        private List<PictureBox> createPlayerPits(int xPosition, int yPosition, int step, int player)
        {
            var pitImages = new List<PictureBox>();
            for (int i = 1; i <= 6; i++)
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
            Console.WriteLine("I see player {0}'s pit {1}!", pit.Player, pit.Location);
        }

        private void createPlayerStore(int xPosition, int player)
        {
            PictureBox picture = new PictureBox
            {
                Name = "Store" + player,
                Location = new Point(xPosition, 20),
                Image = Mancala.Properties.Resources.store,
                Size = Mancala.Properties.Resources.store.Size,
                BackColor = Color.Transparent,
                Visible = true
            };

            boardBox.Controls.Add(picture);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createPits(object sender, EventArgs e)
        {
            int boardWidth = Mancala.Properties.Resources.board.Width;
            int pitWidth = Mancala.Properties.Resources.pit.Width;
            int xOffset = 27;
            int p1 = 1;
            int p2 = 2;
            pitPictureBoxes[p1] = createPlayerPits(xOffset, 175, Mancala.Properties.Resources.pit.Width + 10, p1);
            pitPictureBoxes[p2] = createPlayerPits(boardWidth - pitWidth - xOffset, 20, -(pitWidth + 10), p2);
            setUpPits(pitPictureBoxes);

            createPlayerStore(boardBox.Width - 100, 1);
            createPlayerStore(10, 2);

            var gameState = new GameState();
            render(gameState);
        }

        private void render(GameState gameState)
        {
            render(gameState.playerOne, 1);
            render(gameState.playerTwo, 2);
        }

        private Point scatter(int pebbleIndex, Size pebbleSize, Size pitSize)
        {
            int offset = 10;
            int padding = 5;
            int width = offset + (pebbleSize.Width + padding) * (pebbleIndex % 2);
            int height = offset + (pebbleIndex /2) * (pebbleSize.Height + padding);
            return new Point(width, height);
        }
        private void render(int[] player, int playerId)
        {
            for(var i = 0; i < 6; i++)
            {
                pitPictureBoxes[playerId][i].Controls.Clear();
                for(var j = 0; j < player[i]; j++)
                {
                    PictureBox pebble = new PictureBox
                    {
                        Name = "Pebble",                 
                        Image = Mancala.Properties.Resources.pebble_magenta,
                        Size = Mancala.Properties.Resources.pebble_magenta.Size,
                        BackColor = Color.Transparent,
                        Visible = true
                    };
                    pebble.Location = scatter(j, pebble.Size, pitPictureBoxes[playerId][i].Size);
                    pitPictureBoxes[playerId][i].Controls.Add(pebble);
                }
            }
        }


        /// <summary>
        /// This function starts a player vs AI version of Mancala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            mancalaTabs.SelectedTab = gameTab;

            // TODO: Start a one player vs AI game
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
            mancalaTabs.SelectedTab = gameTab;

            // TODO: Start a two player game. User vs User
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

            mancalaTabs.SelectedTab = menuTab;
        }

        /// <summary>
        /// This function sends the user to an information page about the game of Mancala.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
