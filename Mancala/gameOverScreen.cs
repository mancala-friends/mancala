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
        public gameOverScreen()
        {
            InitializeComponent();
        }

        public gameOverScreen(GameState game)
        {
            InitializeComponent();
            player1ScoreNumLabel.Text = game.playerOne[6].ToString();
            player2ScoreNumLabel.Text = game.playerTwo[6].ToString();
        }

    }
}
