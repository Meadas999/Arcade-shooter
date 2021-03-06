
namespace Tester
{
    partial class MainMenu
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
            this.playKnop = new System.Windows.Forms.Button();
            this.leaderboardKnop = new System.Windows.Forms.Button();
            this.ArcadeMenuLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArcadeMenuLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // playKnop
            // 
            this.playKnop.BackColor = System.Drawing.Color.White;
            this.playKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playKnop.ForeColor = System.Drawing.Color.Black;
            this.playKnop.Location = new System.Drawing.Point(493, 370);
            this.playKnop.Name = "playKnop";
            this.playKnop.Size = new System.Drawing.Size(576, 88);
            this.playKnop.TabIndex = 0;
            this.playKnop.Text = "Play!";
            this.playKnop.UseVisualStyleBackColor = false;
            this.playKnop.Click += new System.EventHandler(this.playKnop_Click);
            // 
            // leaderboardKnop
            // 
            this.leaderboardKnop.BackColor = System.Drawing.Color.White;
            this.leaderboardKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboardKnop.ForeColor = System.Drawing.Color.Black;
            this.leaderboardKnop.Location = new System.Drawing.Point(493, 465);
            this.leaderboardKnop.Name = "leaderboardKnop";
            this.leaderboardKnop.Size = new System.Drawing.Size(576, 88);
            this.leaderboardKnop.TabIndex = 3;
            this.leaderboardKnop.Text = "Leaderboard";
            this.leaderboardKnop.UseVisualStyleBackColor = false;
            this.leaderboardKnop.Click += new System.EventHandler(this.leaderboardKnop_Click);
            // 
            // ArcadeMenuLabel
            // 
            this.ArcadeMenuLabel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ArcadeMenuLabel.Image = global::Tester.Properties.Resources.Arcade;
            this.ArcadeMenuLabel.Location = new System.Drawing.Point(221, 101);
            this.ArcadeMenuLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArcadeMenuLabel.Name = "ArcadeMenuLabel";
            this.ArcadeMenuLabel.Size = new System.Drawing.Size(835, 100);
            this.ArcadeMenuLabel.TabIndex = 2;
            this.ArcadeMenuLabel.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.leaderboardKnop);
            this.Controls.Add(this.ArcadeMenuLabel);
            this.Controls.Add(this.playKnop);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArcadeMenuLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playKnop;
        private System.Windows.Forms.PictureBox ArcadeMenuLabel;
        private System.Windows.Forms.Button leaderboardKnop;
    }
}