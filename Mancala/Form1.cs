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
        public Form1()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void onePlayerButton_Click(object sender, EventArgs e)
        {
            mancalaTabs.SelectedTab = gameTab;
        }

        private void networkButton_Click(object sender, EventArgs e)
        {

        }
    }
}
