using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            //timer2.Start();
            //label1.Text = "Levens: 3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //zombie.MakeZombie(5, this);
        }

    }
}
