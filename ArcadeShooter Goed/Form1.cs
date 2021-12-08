using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcadeShooter_Goed
{
    public partial class Form1 : Form
    {
        Zombie zombie = new Zombie();
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
        int levens;
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


        //private void pic_Click(object sender, EventArgs e)
        //{
        //    PictureBox pic = sender as PictureBox;
        //    hitpoints--;
        //    if (hitpoints == 0)
        //    {
        //        pic.Visible = false;

        //        hitpoints = 10;
        //        lbLifeTank.Text = $"LevenTank: Dead";
        //    }
        //    lbLifeTank.Text = $"LevenTank: {hitpoints}";
        //}

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            zombie.MakeZombie(5, this);
        }



        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
