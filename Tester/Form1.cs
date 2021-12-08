using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        static string[] zombielijst = { "Ludo", "Sanders", "Jantje" };
        static Random random = new Random();
        Zombie Bigzombie = new Zombie(2, zombielijst[1], "Groot");
        Zombie SmallZombie = new Zombie(1, zombielijst[2], "Klein");
        int levens = 3;
        int score = 0;

       




        public Form1()
        {
            InitializeComponent();
            timersnelheid.Start();
            timerMaker.Start();
            test1.Text = "Levens: " + "" + levens;
            label2.Text = Bigzombie.Naam;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void MakeBigZombie(int aantal, Form formInstance)
        {
            
            for (int i = 0; i < aantal; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Image = Properties.Resources.ZombieDik;
                picture.Size = new Size(200, 200);
                picture.Location = new Point(random.Next(1500), 0);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += Bigzombie_Click;
                picture.BackColor = Color.Transparent;
                formInstance.Controls.Add(picture);
            }
        }

        public void MakeSmallZombie(int aantal, Form formInstance)
        {

            for (int i = 0; i < aantal; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Image = Properties.Resources.ZombieCute;
                picture.Size = new Size(200, 200);
                picture.Location = new Point(random.Next(1500), 0);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += Smallzombie_Click;
                picture.BackColor = Color.Transparent;
                formInstance.Controls.Add(picture);
            }
        }


        void Bigzombie_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Bigzombie.Health-- ;
            
            label2.Text = $"Score: {score}";
            
            if (Bigzombie.Health == 0)
            {
                pic.Visible = false;
                this.Controls.Remove(pic);
                pic.Dispose();

                score++;

                Bigzombie.Health = 2;
            }
        }

        void Smallzombie_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SmallZombie.Health--;
            label2.Text = $"Score: {score}";
           
            if (SmallZombie.Health == 0)
            {
                pic.Visible = false;
                this.Controls.Remove(pic);
                pic.Dispose();
                
                score++;
                
                
                SmallZombie.Health = 1;
            }
          
            
       
        }

        public void Zombie()
        {

            foreach (Control control in Controls)
            {
                PictureBox pic = control as PictureBox;
                if (pic != null)
                {
                    pic.Top += 10;
                    if (pic.Top > 600 && pic.Visible == true)
                    {
                        pic.Top = 0;
                        test1.Text = $"Levens: {--levens}";
                    }
                    else if (pic.Top > 600 && pic.Visible == false)
                    {
                        pic.Visible = true;
                        pic.Top = 0;
                    }
                }
            }
        }
        private void timersnelheid_Tick(object sender, EventArgs e)
        {
            Zombie();
        }

        private void timerMaker_Tick(object sender, EventArgs e)
        {
            MakeBigZombie(1, this);
            MakeSmallZombie(5, this);

        }

       
    }
}
