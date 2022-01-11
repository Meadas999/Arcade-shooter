using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO.Ports;



namespace Tester
{
    public partial class Form1 : Form
    {
        
        Random random = new Random();
        Level level = new Level(5,2, 2, 3, 1);
        Player speler = new Player("", 100, 0);
        List<Zombie> zombies = new List<Zombie>();
        int levendezombies;



        public Form1()
        {
            
            InitializeComponent();
            //connectMetArduino();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            timersnelheid.Start();
            timerMaker.Start();
            
            Healthbar.Value = speler.Levens;
            

        }


        public void MakeZombiesList(int mini, int big)
        {
          
            for (int i = 0; i < big; i++)
            {
                zombies.Add(new Zombie(level.tankLevens, "BigMan" + Convert.ToString(i), "Groot", 2));
            }
            for (int i = 0; i < mini; i++)
            {
                zombies.Add(new Zombie(1, "SmallMan" + Convert.ToString(i), "Klein", 1));
            }
            
        }
        public void Form1_Load(object sender, EventArgs e) 
        {
            
            MakeZombiesList(level.aantalZombies, level.aantalTanks);
            ZombieMaker(level.TotaalZombies(), this, "ZombieDik");
            int levendezombies = level.aantalTanks + level.aantalZombies;
        }
       
        public void ZombieMaker(int aantal, Form formInstance, string ZombieDik)
        {
            
            for (int i = 0; i < aantal; i++)
            {              
                PictureBox picture = new PictureBox();
                picture.Image = Properties.Resources.ZombieDik;
                picture.Size = new Size(200, 200);
                picture.Location = new Point(random.Next(1500), 0);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += zombie_Click;
                picture.BackColor = Color.Transparent;
                formInstance.Controls.Add(picture);
                picture.Tag = zombies[i];
            }
            


        }

     
        void zombie_Click(object sender, EventArgs e)
        {

            PictureBox pic = sender as PictureBox;
            Zombie temp = pic.Tag as Zombie;
            


            temp.Health-- ;
            Healthbar.Value = speler.Levens;
            
            if (temp.Health == 0)
            {
                pic.Visible = false;
                this.Controls.Remove(pic);
                pic.Dispose();
                levendezombies++;

                speler.Score++;
                
            }

            if (levendezombies == level.TotaalZombies())
            {
                zombies.Clear();
                level.VolgendeLevel();
                MakeZombiesList(level.aantalZombies, level.aantalTanks);
                ZombieMaker(level.TotaalZombies(), this, "ZombieDik");
                levendezombies = 0;
                
            }  
            

        }
        

        public void gameOver()
        {
            GameOver GameOver = new GameOver(speler);
            this.Hide();
            GameOver.ShowDialog();
            this.Close();
        }

        //void Smallzombie_Click(object sender, EventArgs e)
        //{
        //    PictureBox pic = sender as PictureBox;
        //    SmallZombie.Health--;
            
        //    if (SmallZombie.Health == 0)
        //    {
        //        speler.Score++;
        //        pic.Visible = false;
        //        this.Controls.Remove(pic);
        //        pic.Dispose();
        //        SmallZombie.Health = 1;
        //    }

            

        //}

        List<PictureBox> returnPictureboxes()
        {
            List<PictureBox> ret = new List<PictureBox>();
            foreach (Control control in Controls)
            {
                PictureBox pic = control as PictureBox;
                if (pic != null)
                {
                    ret.Add(pic);
                }
            }
            return ret;
        }

        Boolean finishedLevel()
        {
            return returnPictureboxes().Count == 0;
        }

        public void ZombieSnelheid()
        {
            foreach (PictureBox pic in returnPictureboxes())
            {

                pic.Top += 10;
                if (pic.Top > 600 && pic.Visible == true)
                {
                    pic.Top = 10;
                    if(speler.Levens >0)
                    {
                        speler.Levens -= 10;
                        Healthbar.Value = speler.Levens;
                        if(speler.Levens <= 31)
                        {
                            Healthbar.SetState(2);
                        }
                    }
                    else
                    {
                        gameOver();
                    }

                        

                }
                
            }
        }
        private void timersnelheid_Tick(object sender, EventArgs e)
        {
            ZombieSnelheid();
        }
        private void timerMaker_Tick(object sender, EventArgs e)
        {
            
            //MakeSmallZombie(5, this);

        }
        public void MakeTimer()
        {
            Timer timer = new Timer();
            {
                timer.Interval = 1000;
            }
            timer.Enabled = true;
            timer.Tick += new EventHandler(MyTimer_Tick);
            timer.Start();
        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {

        }
        private void connectMetArduino()
        { 
            //port.Open();
            //port.Write("#STAR\n");
        } 
        private void target1()
        {
            MakeTimer();

        }

        private void timeChecker_Tick(object sender, EventArgs e)
        {
            Healthbar.Value = speler.Levens;
        }
    }
}
