
namespace ArcadeShooter_test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLifeTank = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.p_3 = new System.Windows.Forms.PictureBox();
            this.p_2 = new System.Windows.Forms.PictureBox();
            this.p_1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(833, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(621, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lbLifeTank
            // 
            this.lbLifeTank.AutoSize = true;
            this.lbLifeTank.Location = new System.Drawing.Point(998, 55);
            this.lbLifeTank.Name = "lbLifeTank";
            this.lbLifeTank.Size = new System.Drawing.Size(103, 17);
            this.lbLifeTank.TabIndex = 5;
            this.lbLifeTank.Text = "LevenTank: 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 78);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // p_3
            // 
            this.p_3.BackColor = System.Drawing.Color.Transparent;
            this.p_3.Image = ((System.Drawing.Image)(resources.GetObject("p_3.Image")));
            this.p_3.Location = new System.Drawing.Point(1039, 171);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(130, 115);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_3.TabIndex = 2;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.pic_Click);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.White;
            this.p_2.Image = global::ArcadeShooter_test.Properties.Resources._108_1086909_zombies_peashooter_pixel_minecraft_plants_vs_zombies_pixel;
            this.p_2.Location = new System.Drawing.Point(392, 96);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(130, 115);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_2.TabIndex = 1;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.pics_Click);
            // 
            // p_1
            // 
            this.p_1.Image = global::ArcadeShooter_test.Properties.Resources._108_1086909_zombies_peashooter_pixel_minecraft_plants_vs_zombies_pixel;
            this.p_1.Location = new System.Drawing.Point(167, 226);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(130, 115);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.p_1.TabIndex = 0;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.pics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLifeTank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.p_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p_1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p_1;
        private System.Windows.Forms.PictureBox p_2;
        private System.Windows.Forms.PictureBox p_3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLifeTank;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
    }
}

