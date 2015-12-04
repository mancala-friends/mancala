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
        /// <summary>
        /// THis function sets up the about form the way it was designed in the designer when started.
        /// </summary>
        public aboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This function closes the about form when the user pushes the close button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeButton_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /// <summary>
        /// This Function send the user to the Mancala github page when the link is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void distroLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            distroLink.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/mancala-friends/mancala");
        }

        /// <summary>
        /// This function allows the user to download the zip file of Mancala from the github site.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void downloadZip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            downloadZip.LinkVisited = true;

            System.Diagnostics.Process.Start("https://github.com/mancala-friends/mancala/archive/master.zip");
        }
    }
}
