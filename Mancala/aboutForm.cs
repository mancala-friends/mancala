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
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void distroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            distroLink.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/mancala-friends/mancala");
        }
    }
}
