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
            mancalaTabs.TabPages.Remove(gameTab);
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
            mancalaTabs.TabPages.Add(gameTab);
            mancalaTabs.SelectedTab = gameTab;
            mancalaTabs.TabPages.Remove(menuTab);

            // TODO: Start a two player game. User vs User

            GameState game = new GameState();
            Rules gameRules = new Rules();
            Console.Write(game.currentPlayer);

            if(game.currentPlayer == 1)
            {
                player1Label.Font = new Font(player1Label.Font, FontStyle.Italic);
                player2Label.Font = new Font(player2Label.Font, FontStyle.Regular);
                
            }else
            {
                player2Label.Font = new Font(player2Label.Font, FontStyle.Italic);
                player1Label.Font = new Font(player1Label.Font, FontStyle.Regular);
            }


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
