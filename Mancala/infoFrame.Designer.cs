namespace Mancala
{
    partial class infoFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infoFrame));
            this.infoTitleLabel = new System.Windows.Forms.Label();
            this.rulesLabel = new System.Windows.Forms.Label();
            this.specialCondLabel = new System.Windows.Forms.Label();
            this.instructionsTextBox = new System.Windows.Forms.RichTextBox();
            this.conditionRulesLabel = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // infoTitleLabel
            // 
            this.infoTitleLabel.AutoSize = true;
            this.infoTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.infoTitleLabel.Name = "infoTitleLabel";
            this.infoTitleLabel.Size = new System.Drawing.Size(506, 61);
            this.infoTitleLabel.TabIndex = 0;
            this.infoTitleLabel.Text = "Mancala Information";
            // 
            // rulesLabel
            // 
            this.rulesLabel.AutoSize = true;
            this.rulesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rulesLabel.Location = new System.Drawing.Point(13, 70);
            this.rulesLabel.Name = "rulesLabel";
            this.rulesLabel.Size = new System.Drawing.Size(73, 25);
            this.rulesLabel.TabIndex = 1;
            this.rulesLabel.Text = "Rules:";
            // 
            // specialCondLabel
            // 
            this.specialCondLabel.AutoSize = true;
            this.specialCondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialCondLabel.Location = new System.Drawing.Point(13, 244);
            this.specialCondLabel.Name = "specialCondLabel";
            this.specialCondLabel.Size = new System.Drawing.Size(197, 25);
            this.specialCondLabel.TabIndex = 2;
            this.specialCondLabel.Text = "Special Conditions:";
            // 
            // instructionsTextBox
            // 
            this.instructionsTextBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.instructionsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.instructionsTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.instructionsTextBox.Location = new System.Drawing.Point(18, 98);
            this.instructionsTextBox.Name = "instructionsTextBox";
            this.instructionsTextBox.ReadOnly = true;
            this.instructionsTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.instructionsTextBox.Size = new System.Drawing.Size(499, 143);
            this.instructionsTextBox.TabIndex = 3;
            this.instructionsTextBox.Text = resources.GetString("instructionsTextBox.Text");
            // 
            // conditionRulesLabel
            // 
            this.conditionRulesLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.conditionRulesLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.conditionRulesLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.conditionRulesLabel.Location = new System.Drawing.Point(18, 272);
            this.conditionRulesLabel.Name = "conditionRulesLabel";
            this.conditionRulesLabel.ReadOnly = true;
            this.conditionRulesLabel.Size = new System.Drawing.Size(499, 200);
            this.conditionRulesLabel.TabIndex = 4;
            this.conditionRulesLabel.Text = resources.GetString("conditionRulesLabel.Text");
            // 
            // infoFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(529, 484);
            this.Controls.Add(this.conditionRulesLabel);
            this.Controls.Add(this.instructionsTextBox);
            this.Controls.Add(this.specialCondLabel);
            this.Controls.Add(this.rulesLabel);
            this.Controls.Add(this.infoTitleLabel);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "infoFrame";
            this.Text = "Game Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoTitleLabel;
        private System.Windows.Forms.Label rulesLabel;
        private System.Windows.Forms.Label specialCondLabel;
        private System.Windows.Forms.RichTextBox instructionsTextBox;
        private System.Windows.Forms.RichTextBox conditionRulesLabel;
    }
}