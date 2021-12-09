
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
            this.naamConfirmTB = new System.Windows.Forms.TextBox();
            this.naamConfirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameoverPic)).BeginInit();
            this.SuspendLayout();
            // 
            // gameoverPic
            // 
            this.gameoverPic.BackColor = System.Drawing.Color.Transparent;
            this.gameoverPic.Image = global::Tester.Properties.Resources.GameOver;
            this.gameoverPic.Location = new System.Drawing.Point(294, 192);
            this.gameoverPic.Name = "gameoverPic";
            this.gameoverPic.Size = new System.Drawing.Size(663, 98);
            this.gameoverPic.TabIndex = 3;
            this.gameoverPic.TabStop = false;
            // 
            // naamConfirmTB
            // 
            this.naamConfirmTB.Location = new System.Drawing.Point(439, 333);
            this.naamConfirmTB.Name = "naamConfirmTB";
            this.naamConfirmTB.Size = new System.Drawing.Size(372, 20);
            this.naamConfirmTB.TabIndex = 4;
            // 
            // naamConfirmBtn
            // 
            this.naamConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naamConfirmBtn.Location = new System.Drawing.Point(564, 389);
            this.naamConfirmBtn.Name = "naamConfirmBtn";
            this.naamConfirmBtn.Size = new System.Drawing.Size(124, 32);
            this.naamConfirmBtn.TabIndex = 5;
            this.naamConfirmBtn.Text = "Confirm name!";
            this.naamConfirmBtn.UseVisualStyleBackColor = true;
            this.naamConfirmBtn.Click += new System.EventHandler(this.naamConfirmBtn_Click);
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.naamConfirmBtn);
            this.Controls.Add(this.naamConfirmTB);
            this.Controls.Add(this.gameoverPic);
            this.Name = "GameOver";
            this.Text = "GameOver";
            ((System.ComponentModel.ISupportInitialize)(this.gameoverPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gameoverPic;
        private System.Windows.Forms.TextBox naamConfirmTB;
        private System.Windows.Forms.Button naamConfirmBtn;
    }
}