
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timersnelheid
            // 
            this.timersnelheid.Interval = 200;
            this.timersnelheid.Tick += new System.EventHandler(this.timersnelheid_Tick);
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
            this.Healthbar.Location = new System.Drawing.Point(334, 37);
            this.Healthbar.Margin = new System.Windows.Forms.Padding(2);
            this.Healthbar.Name = "Healthbar";
            this.Healthbar.Size = new System.Drawing.Size(292, 48);
            this.Healthbar.TabIndex = 2;
            this.Healthbar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(700, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(775, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::Tester.Properties.Resources.grass;
            this.ClientSize = new System.Drawing.Size(948, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Healthbar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timersnelheid;
        private System.Windows.Forms.Timer timerMaker;
        private System.Windows.Forms.Timer timeChecker;
        private System.Windows.Forms.ProgressBar Healthbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

