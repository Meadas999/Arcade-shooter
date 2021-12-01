using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace ArcadeShooter_test
{
    public partial class Form1 : Form
    {
        int levens = 3;
        int score = 0;
        int hitpoints = 10;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            timer2.Start();
            label1.Text = "Levens: 3";
            ////Bitmap bmp = new Bitmap(Properties.Resources.crosshair);
            //Cursor crsr = new Cursor(bmp.GetHicon()); 
            //this.Cursor = crsr;  

        }

        void Zombie()
        {

            foreach (Control control in Controls)
            {
                PictureBox pic = control as PictureBox;
                if (pic != null)
                {
                    pic.Top += 1;
                    if (pic.Top > 600 && pic.Visible == true)
                    {

                        pic.Top = 0;
                        label1.Text = $"Levens: {--levens}";
                    }
                    else if (pic.Top > 600 && pic.Visible == false)
                    {
                        pic.Visible = true;
                        pic.Top = 0;
                    }
                }
            }
        }
        void MakeZombie(int aantal)
        {
            for (int i = 0; i < aantal; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Image = Properties.Resources.ZombieDik;
                picture.Size = new Size(200, 200);
                picture.Location = new Point(random.Next(1500), 0);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += pics_Click; 
                picture.BackColor = Color.Transparent;
                this.Controls.Add(picture);
            }


        }
        private void pics_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Visible = false;
            score++;
            label2.Text = $"Score: {score}";
            this.Controls.Remove(pic);
            pic.Dispose();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            hitpoints--;
            if (hitpoints == 0)
            {
                pic.Visible = false;

                hitpoints = 10;
                lbLifeTank.Text = $"LevenTank: Dead";
            }
            lbLifeTank.Text = $"LevenTank: {hitpoints}";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Zombie();
        }

    

        private void timer2_Tick(object sender, EventArgs e)
        {
            MakeZombie(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}