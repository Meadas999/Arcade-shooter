
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
            this.timeChecker = new System.Windows.Forms.Timer(this.components);
            this.Healthbar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.messageTimer = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LevelLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timersnelheid
            // 
            this.timersnelheid.Interval = 400;
            this.timersnelheid.Tick += new System.EventHandler(this.timersnelheid_Tick);
            // 
            // timeChecker
            // 
            this.timeChecker.Tick += new System.EventHandler(this.timeChecker_Tick);
            // 
            // Healthbar
            // 
            this.Healthbar.BackColor = System.Drawing.SystemColors.Control;
            this.Healthbar.ForeColor = System.Drawing.Color.Blue;
            this.Healthbar.Location = new System.Drawing.Point(249, 37);
            this.Healthbar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Healthbar.Name = "Healthbar";
            this.Healthbar.Size = new System.Drawing.Size(389, 59);
            this.Healthbar.TabIndex = 2;
            this.Healthbar.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // LevelLbl
            // 
            this.LevelLbl.AutoSize = true;
            this.LevelLbl.BackColor = System.Drawing.Color.White;
            this.LevelLbl.Location = new System.Drawing.Point(700, 37);
            this.LevelLbl.Name = "LevelLbl";
            this.LevelLbl.Size = new System.Drawing.Size(46, 17);
            this.LevelLbl.TabIndex = 3;
            this.LevelLbl.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Tester.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.LevelLbl);
            this.Controls.Add(this.Healthbar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timersnelheid;
        private System.Windows.Forms.Timer timeChecker;
        private System.Windows.Forms.ProgressBar Healthbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer cooldownTimer;
        private System.Windows.Forms.Timer messageTimer;
        public System.Windows.Forms.Timer timerMaker;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LevelLbl;
    }
}

