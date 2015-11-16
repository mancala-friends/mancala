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

        private void createPlayerPits(int xPosition, int yPosition, int step, int player)
        {
            for (int i = 1; i <= 6; i++)
            {
                PictureBox picture = new PictureBox
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

                boardBox.Controls.Add(picture);
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
            createPlayerPits(xOffset, 175, Mancala.Properties.Resources.pit.Width + 10, 1);
            createPlayerPits(boardWidth - pitWidth - xOffset, 20, -(pitWidth + 10), 2);
            createPlayerStore(boardBox.Width - 100, 1);
            createPlayerStore(10, 2);
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
