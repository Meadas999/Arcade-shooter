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
        
        Player speler = new Player("", 100, 0);
        
       
       




        public Form1()
        {
            InitializeComponent();
            timersnelheid.Start();
            timerMaker.Start();
            //timeChecker.Start();
            Healthbar.Value = speler.Levens;

            
           
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

            Healthbar.Value = speler.Levens;

            if (Bigzombie.Health == 0)
            {
                pic.Visible = false;
                this.Controls.Remove(pic);
                pic.Dispose();

                speler.Score++;

                Bigzombie.Health = 2;
            }
        }
        

        public void gameOver()
        {
            GameOver GameOver = new GameOver(speler);
            this.Hide();
            GameOver.ShowDialog();
            this.Close();
        }

        void Smallzombie_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            SmallZombie.Health--;
            
            if (SmallZombie.Health == 0)
            {
                speler.Score++;
                pic.Visible = false;
                this.Controls.Remove(pic);
                pic.Dispose();



                
                SmallZombie.Health = 1;
            }

            

        }

        public void mZombie()
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
                        if(speler.Levens !=0)
                        {
                            speler.Levens -= 10;
                            Healthbar.Value = speler.Levens;
                            if(speler.Levens == 30)
                            {
                                Healthbar.SetState(2);
                            }
                        }
                        else if(speler.Levens <=0 )
                        {
                            gameOver();
                        }

                        

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
            mZombie();
        }

        private void timerMaker_Tick(object sender, EventArgs e)
        {
            MakeBigZombie(1, this);
            MakeSmallZombie(5, this);

        }

        private void timeChecker_Tick(object sender, EventArgs e)
        {
            Healthbar.Value = speler.Levens;
        }
    }
}
