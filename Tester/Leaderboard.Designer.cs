﻿
namespace Tester
{
    partial class Leaderboard
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
            this.terugKnop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // terugKnop
            // 
            this.terugKnop.Location = new System.Drawing.Point(38, 400);
            this.terugKnop.Name = "terugKnop";
            this.terugKnop.Size = new System.Drawing.Size(75, 23);
            this.terugKnop.TabIndex = 0;
            this.terugKnop.Text = "back";
            this.terugKnop.UseVisualStyleBackColor = true;
            this.terugKnop.Click += new System.EventHandler(this.terugKnop_Click);
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.terugKnop);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button terugKnop;
    }
}