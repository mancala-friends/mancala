namespace Mancala
{
    partial class aboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(aboutForm));
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.versionDisplayLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.distroDisplayLabel = new System.Windows.Forms.Label();
            this.distroLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(159, 276);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // versionDisplayLabel
            // 
            this.versionDisplayLabel.AutoSize = true;
            this.versionDisplayLabel.Location = new System.Drawing.Point(16, 183);
            this.versionDisplayLabel.Name = "versionDisplayLabel";
            this.versionDisplayLabel.Size = new System.Drawing.Size(115, 13);
            this.versionDisplayLabel.TabIndex = 2;
            this.versionDisplayLabel.Text = "The current version is: ";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(156, 183);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(60, 13);
            this.versionLabel.TabIndex = 3;
            this.versionLabel.Text = "Version 1.0";
            // 
            // distroDisplayLabel
            // 
            this.distroDisplayLabel.AutoSize = true;
            this.distroDisplayLabel.Location = new System.Drawing.Point(19, 222);
            this.distroDisplayLabel.Name = "distroDisplayLabel";
            this.distroDisplayLabel.Size = new System.Drawing.Size(128, 13);
            this.distroDisplayLabel.TabIndex = 4;
            this.distroDisplayLabel.Text = "Program Distribution Site: ";
            // 
            // distroLink
            // 
            this.distroLink.AutoSize = true;
            this.distroLink.Location = new System.Drawing.Point(156, 222);
            this.distroLink.Name = "distroLink";
            this.distroLink.Size = new System.Drawing.Size(219, 13);
            this.distroLink.TabIndex = 5;
            this.distroLink.TabStop = true;
            this.distroLink.Text = "https://github.com/mancala-friends/mancala";
            this.distroLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.distroLink_LinkClicked);
            // 
            // aboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 311);
            this.Controls.Add(this.distroLink);
            this.Controls.Add(this.distroDisplayLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionDisplayLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Name = "aboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionDisplayLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label distroDisplayLabel;
        private System.Windows.Forms.LinkLabel distroLink;
    }
}