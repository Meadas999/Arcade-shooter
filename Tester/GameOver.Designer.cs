
namespace Tester
{
    partial class GameOver
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
            this.gameoverPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gameoverPic
            // 
            this.gameoverPic.BackColor = System.Drawing.Color.Transparent;
            this.gameoverPic.Image = global::Tester.Properties.Resources.GameOver;
            this.gameoverPic.Location = new System.Drawing.Point(316, 187);
            this.gameoverPic.Name = "gameoverPic";
            this.gameoverPic.Size = new System.Drawing.Size(663, 98);
            this.gameoverPic.TabIndex = 3;
            this.gameoverPic.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.gameoverPic);
            this.Name = "GameOver";
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.gameoverPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox gameoverPic;
    }
}