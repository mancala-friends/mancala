namespace Mancala
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mancalaTabs = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.infoButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuTab = new System.Windows.Forms.TabPage();
            this.exitButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.instructionButton = new System.Windows.Forms.Button();
            this.networkButton = new System.Windows.Forms.Button();
            this.twoPlayerButton = new System.Windows.Forms.Button();
            this.onePlayerButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.mancalaTabs.SuspendLayout();
            this.gameTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "board.png");
            // 
            // mancalaTabs
            // 
            this.mancalaTabs.Controls.Add(this.gameTab);
            this.mancalaTabs.Controls.Add(this.menuTab);
            this.mancalaTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mancalaTabs.Location = new System.Drawing.Point(0, 0);
            this.mancalaTabs.Name = "mancalaTabs";
            this.mancalaTabs.SelectedIndex = 0;
            this.mancalaTabs.Size = new System.Drawing.Size(784, 561);
            this.mancalaTabs.TabIndex = 3;
            // 
            // gameTab
            // 
            this.gameTab.Controls.Add(this.infoButton);
            this.gameTab.Controls.Add(this.backButton);
            this.gameTab.Controls.Add(this.pictureBox1);
            this.gameTab.Location = new System.Drawing.Point(4, 22);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(776, 535);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game";
            this.gameTab.UseVisualStyleBackColor = true;
            // 
            // infoButton
            // 
            this.infoButton.Image = global::Mancala.Properties.Resources.info;
            this.infoButton.Location = new System.Drawing.Point(204, 427);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(95, 100);
            this.infoButton.TabIndex = 5;
            this.infoButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.Image = global::Mancala.Properties.Resources.back_button;
            this.backButton.Location = new System.Drawing.Point(37, 427);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(161, 100);
            this.backButton.TabIndex = 4;
            this.backButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mancala.Properties.Resources.board;
            this.pictureBox1.InitialImage = global::Mancala.Properties.Resources.board;
            this.pictureBox1.Location = new System.Drawing.Point(37, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(708, 302);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuTab
            // 
            this.menuTab.Controls.Add(this.titleLabel);
            this.menuTab.Controls.Add(this.exitButton);
            this.menuTab.Controls.Add(this.aboutButton);
            this.menuTab.Controls.Add(this.instructionButton);
            this.menuTab.Controls.Add(this.networkButton);
            this.menuTab.Controls.Add(this.twoPlayerButton);
            this.menuTab.Controls.Add(this.onePlayerButton);
            this.menuTab.Location = new System.Drawing.Point(4, 22);
            this.menuTab.Name = "menuTab";
            this.menuTab.Padding = new System.Windows.Forms.Padding(3);
            this.menuTab.Size = new System.Drawing.Size(776, 535);
            this.menuTab.TabIndex = 1;
            this.menuTab.Text = "Menu";
            this.menuTab.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(61, 337);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(184, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit Game";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(61, 292);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(184, 23);
            this.aboutButton.TabIndex = 4;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            // 
            // instructionButton
            // 
            this.instructionButton.Location = new System.Drawing.Point(61, 252);
            this.instructionButton.Name = "instructionButton";
            this.instructionButton.Size = new System.Drawing.Size(184, 23);
            this.instructionButton.TabIndex = 3;
            this.instructionButton.Text = "Instructions";
            this.instructionButton.UseVisualStyleBackColor = true;
            // 
            // networkButton
            // 
            this.networkButton.Location = new System.Drawing.Point(61, 160);
            this.networkButton.Name = "networkButton";
            this.networkButton.Size = new System.Drawing.Size(184, 23);
            this.networkButton.TabIndex = 2;
            this.networkButton.Text = "Networked Game";
            this.networkButton.UseVisualStyleBackColor = true;
            this.networkButton.Click += new System.EventHandler(this.networkButton_Click);
            // 
            // twoPlayerButton
            // 
            this.twoPlayerButton.Location = new System.Drawing.Point(61, 111);
            this.twoPlayerButton.Name = "twoPlayerButton";
            this.twoPlayerButton.Size = new System.Drawing.Size(184, 23);
            this.twoPlayerButton.TabIndex = 1;
            this.twoPlayerButton.Text = "2 Player Game";
            this.twoPlayerButton.UseVisualStyleBackColor = true;
            // 
            // onePlayerButton
            // 
            this.onePlayerButton.Location = new System.Drawing.Point(61, 82);
            this.onePlayerButton.Name = "onePlayerButton";
            this.onePlayerButton.Size = new System.Drawing.Size(184, 23);
            this.onePlayerButton.TabIndex = 0;
            this.onePlayerButton.Text = "1 Player Game";
            this.onePlayerButton.UseVisualStyleBackColor = true;
            this.onePlayerButton.Click += new System.EventHandler(this.onePlayerButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(146, 3);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(485, 55);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Welcome to Mancala!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mancalaTabs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mancalaTabs.ResumeLayout(false);
            this.gameTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuTab.ResumeLayout(false);
            this.menuTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabControl mancalaTabs;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage menuTab;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button instructionButton;
        private System.Windows.Forms.Button networkButton;
        private System.Windows.Forms.Button twoPlayerButton;
        private System.Windows.Forms.Button onePlayerButton;
        private System.Windows.Forms.Label titleLabel;
    }
}

