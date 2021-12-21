﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.IO.Ports;


namespace Tester
{
    public partial class Form1 : Form
    {
        string[] zombielijst = { "Ludo", "Sanders", "Jantje" };
        Random random = new Random();
        Zombie Bigzombie;
        Zombie SmallZombie;
        Level level = new Level(1, 2,  2, 400,20);
        Player speler = new Player("", 100, 0);
        List<Zombie> zombies = new List<Zombie>();
        int BigZombieHealth = 0;
        public Form1()

        {
            SerialPort port;
            port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            InitializeComponent();
            connectMetArduino();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            timersnelheid.Start();
            timerMaker.Start();
           timeChecker.Start();
            Healthbar.Value = speler.Levens;
            Bigzombie = new Zombie(2, zombielijst[1], "Groot");
            SmallZombie = new Zombie(1, zombielijst[2], "Klein");
            timersnelheid.Interval = level.snelheid; 
        }

        private void Form1_Load(object sender, EventArgs e) {
            BigZombieHealth = Bigzombie.Health;
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
                //picture.Tag()
                formInstance.Controls.Add(picture);
            }
        }
        public void TestZombie()
        {
            PictureBox picture = new PictureBox();
            while(Overlappen(picture))
            {
                picture.Image = Properties.Resources.ZombieCute;
                picture.Size = new Size(200, 200);
                picture.Location = new Point(random.Next(1500), 0);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Click += Smallzombie_Click;
                picture.BackColor = Color.Transparent; 

                this.Controls.Add(picture);
            }
        }
        public bool Overlappen(PictureBox current)
        {
            bool intersect = false;
            foreach(var pic in returnPictureboxes())
            {
                if (current.Bounds.IntersectsWith(pic.Bounds))
                {
                    intersect = true;
                }
            }
            return intersect;
        }
        void Bigzombie_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            BigZombieHealth-- ;
            Healthbar.Value = speler.Levens;

            if (BigZombieHealth == 0)
            {
                pic.Visible = false;
                this.Controls.Remove(pic);
                pic.Dispose();
                speler.Score++;
                BigZombieHealth = Bigzombie.Health;
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

        public Boolean finishedLevel()
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
                        if(speler.Levens == 30)
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
            MakeBigZombie(1, this);
            MakeSmallZombie(level.aantalZombies, this);
            target1();
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
            //seconden++; 
        }
        private void connectMetArduino()
        { 
            //port.Open();
            //port.Write("#STAR\n");
        } 
        private void target1()
        {
            MakeTimer();
            //port.Write("#T1ON\n");

            //if (seconden == 5)
            {
                //port.Write("#T1OF\n");
                speler.Levens -= 10;
            }
                //port.Write("#T1OF\n");
        }

        private void timeChecker_Tick(object sender, EventArgs e)
        {
            Healthbar.Value = speler.Levens;
        } 
        
        
    }
}
