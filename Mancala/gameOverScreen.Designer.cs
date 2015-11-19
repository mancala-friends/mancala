namespace Mancala
{
    partial class gameOverScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.player1ScoreLabel = new System.Windows.Forms.Label();
            this.player2ScoreLabel = new System.Windows.Forms.Label();
            this.player1ScoreNumLabel = new System.Windows.Forms.Label();
            this.player2ScoreNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!!";
            // 
            // player1ScoreLabel
            // 
            this.player1ScoreLabel.AutoSize = true;
            this.player1ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreLabel.Location = new System.Drawing.Point(80, 146);
            this.player1ScoreLabel.Name = "player1ScoreLabel";
            this.player1ScoreLabel.Size = new System.Drawing.Size(199, 31);
            this.player1ScoreLabel.TabIndex = 1;
            this.player1ScoreLabel.Text = "Player 1 Score:";
            // 
            // player2ScoreLabel
            // 
            this.player2ScoreLabel.AutoSize = true;
            this.player2ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreLabel.Location = new System.Drawing.Point(463, 146);
            this.player2ScoreLabel.Name = "player2ScoreLabel";
            this.player2ScoreLabel.Size = new System.Drawing.Size(199, 31);
            this.player2ScoreLabel.TabIndex = 2;
            this.player2ScoreLabel.Text = "Player 2 Score:";
            // 
            // player1ScoreNumLabel
            // 
            this.player1ScoreNumLabel.AutoSize = true;
            this.player1ScoreNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1ScoreNumLabel.Location = new System.Drawing.Point(136, 194);
            this.player1ScoreNumLabel.Name = "player1ScoreNumLabel";
            this.player1ScoreNumLabel.Size = new System.Drawing.Size(0, 61);
            this.player1ScoreNumLabel.TabIndex = 3;
            // 
            // player2ScoreNumLabel
            // 
            this.player2ScoreNumLabel.AutoSize = true;
            this.player2ScoreNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2ScoreNumLabel.Location = new System.Drawing.Point(514, 194);
            this.player2ScoreNumLabel.Name = "player2ScoreNumLabel";
            this.player2ScoreNumLabel.Size = new System.Drawing.Size(0, 61);
            this.player2ScoreNumLabel.TabIndex = 4;
            // 
            // gameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 293);
            this.Controls.Add(this.player2ScoreNumLabel);
            this.Controls.Add(this.player1ScoreNumLabel);
            this.Controls.Add(this.player2ScoreLabel);
            this.Controls.Add(this.player1ScoreLabel);
            this.Controls.Add(this.label1);
            this.Name = "gameOverScreen";
            this.Text = "gameOverScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player1ScoreLabel;
        private System.Windows.Forms.Label player2ScoreLabel;
        private System.Windows.Forms.Label player1ScoreNumLabel;
        private System.Windows.Forms.Label player2ScoreNumLabel;
    }
}