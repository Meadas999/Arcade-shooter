
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
            this.timersnelheid.Interval = 200;
            this.timersnelheid.Tick += new System.EventHandler(this.timersnelheid_Tick);
            // 
            // test1
            // 
            this.test1.AutoSize = true;
            this.test1.BackColor = System.Drawing.Color.Transparent;
            this.test1.Location = new System.Drawing.Point(495, 41);
            this.test1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(39, 17);
            this.test1.TabIndex = 0;
            this.test1.Text = "test1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(617, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // timerMaker
            // 
            this.timerMaker.Interval = 8000;
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
            this.Healthbar.Location = new System.Drawing.Point(446, 45);
            this.Healthbar.Name = "Healthbar";
            this.Healthbar.Size = new System.Drawing.Size(389, 59);
            this.Healthbar.TabIndex = 2;
            this.Healthbar.Value = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Tester.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Healthbar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.test1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timersnelheid;
        private System.Windows.Forms.Timer timerMaker;
        private System.Windows.Forms.Timer timeChecker;
        private System.Windows.Forms.ProgressBar Healthbar;
    }
}

