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
    public partial class gameOverScreen : Form
    {
        /// <summary>
        /// Constructor for the game over scree. This just initialized the form as was designed.
        /// </summary>
        public gameOverScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  This sets up the game over screen as designed in the designer. Shows Both player's scores
        ///  as well as who has won the game.
        /// </summary>
        /// <param name="game"></param>
        public gameOverScreen(GameState game)
        {
            InitializeComponent();
            int p1Score = game.playerOne[6];
            int p2Score = game.playerTwo[6];

            string p1 = game.playerOne[6].ToString();
            string p2 = game.playerTwo[6].ToString();

            player1ScoreNumLabel.Text = p1;
            player2ScoreNumLabel.Text = p2;


            // Logic to determine how to show which player has won.
            if(p1Score > p2Score)
            {
                winLoseLabel.Text = "Player 1 Wins!";

            }else if(p2Score > p1Score)
            {
                winLoseLabel.Text = "Player 2 Wins!";
            }
            else
            {
                winLoseLabel.Text = "It's a TIE!";
            }
            
        }

    }
}
