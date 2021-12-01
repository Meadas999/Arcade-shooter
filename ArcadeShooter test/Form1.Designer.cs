
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
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(625, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(466, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // lbLifeTank
            // 
            this.lbLifeTank.AutoSize = true;
            this.lbLifeTank.BackColor = System.Drawing.Color.White;
            this.lbLifeTank.Location = new System.Drawing.Point(748, 45);
            this.lbLifeTank.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbLifeTank.Name = "lbLifeTank";
            this.lbLifeTank.Size = new System.Drawing.Size(80, 13);
            this.lbLifeTank.TabIndex = 5;
            this.lbLifeTank.Text = "LevenTank: 10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(501, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
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
            this.p_3.Location = new System.Drawing.Point(580, 179);
            this.p_3.Margin = new System.Windows.Forms.Padding(2);
            this.p_3.Name = "p_3";
            this.p_3.Size = new System.Drawing.Size(98, 93);
            this.p_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.p_3.TabIndex = 2;
            this.p_3.TabStop = false;
            this.p_3.Click += new System.EventHandler(this.pic_Click);
            // 
            // p_2
            // 
            this.p_2.BackColor = System.Drawing.Color.Transparent;
            this.p_2.Image = global::ArcadeShooter_test.Properties.Resources.ZombieDik;
            this.p_2.InitialImage = global::ArcadeShooter_test.Properties.Resources.ZombieDik;
            this.p_2.Location = new System.Drawing.Point(305, 128);
            this.p_2.Margin = new System.Windows.Forms.Padding(2);
            this.p_2.Name = "p_2";
            this.p_2.Size = new System.Drawing.Size(200, 200);
            this.p_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_2.TabIndex = 1;
            this.p_2.TabStop = false;
            this.p_2.Click += new System.EventHandler(this.pics_Click);
            // 
            // p_1
            // 
            this.p_1.BackColor = System.Drawing.Color.Transparent;
            this.p_1.Image = global::ArcadeShooter_test.Properties.Resources.ZombieDik;
            this.p_1.Location = new System.Drawing.Point(76, 208);
            this.p_1.Margin = new System.Windows.Forms.Padding(2);
            this.p_1.Name = "p_1";
            this.p_1.Size = new System.Drawing.Size(200, 200);
            this.p_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.p_1.TabIndex = 0;
            this.p_1.TabStop = false;
            this.p_1.Click += new System.EventHandler(this.pics_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::ArcadeShooter_test.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbLifeTank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p_3);
            this.Controls.Add(this.p_2);
            this.Controls.Add(this.p_1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
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

