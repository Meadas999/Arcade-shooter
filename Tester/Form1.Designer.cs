
namespace Tester
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
            this.timersnelheid = new System.Windows.Forms.Timer(this.components);
            this.timerMaker = new System.Windows.Forms.Timer(this.components);
            this.timeChecker = new System.Windows.Forms.Timer(this.components);
            this.Healthbar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // timersnelheid
            // 
            this.timersnelheid.Interval = 400;
            this.timersnelheid.Tick += new System.EventHandler(this.timersnelheid_Tick);
            // 
            // timerMaker
            // 
            this.timerMaker.Enabled = true;
            this.timerMaker.Interval = 5000;
            this.timerMaker.Tick += new System.EventHandler(this.timerMaker_Tick);
            // 
            // timeChecker
            // 
            this.timeChecker.Tick += new System.EventHandler(this.timeChecker_Tick);
            // 
            // Healthbar
            // 
            this.Healthbar.BackColor = System.Drawing.SystemColors.Control;
            this.Healthbar.ForeColor = System.Drawing.Color.Blue;
            this.Healthbar.Location = new System.Drawing.Point(445, 46);
            this.Healthbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Healthbar.Name = "Healthbar";
            this.Healthbar.Size = new System.Drawing.Size(389, 59);
            this.Healthbar.TabIndex = 2;
            this.Healthbar.Value = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Tester.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Healthbar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timersnelheid;
        private System.Windows.Forms.Timer timeChecker;
        private System.Windows.Forms.ProgressBar Healthbar;
        public System.Windows.Forms.Timer timerMaker;
    }
}

