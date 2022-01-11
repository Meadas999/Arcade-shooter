﻿using System;
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
        bool isConnected = false;
        SerialPort port;
        string message;
        int levendezombies;



        public Form1()

        {

            SerialPort port;
            port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);

            //port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);

            InitializeComponent();
            //connectMetArduino();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            messageTimer.Start();
            timer1.Start();
            timersnelheid.Start();
            timerMaker.Start();
           timeChecker.Start();
            Healthbar.Value = speler.Levens;
            timersnelheid.Interval = level.snelheid; 
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

        void p_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            var serial = (SerialPort)sender;

             message = serial.ReadExisting();

            
           

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

        }
        private void connectMetArduino()
        {
            isConnected = true;
            string selectedPort = "COM14";
            try
            {
                port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
                //port.DataReceived += new SerialDataReceivedEventHandler(p_DataReceived);
                port.Open();

            }
            catch (Exception es)
            {
                MessageBox.Show("Failed to connect");
            }
        } 
        

        private void GetPhysicalZombies()
        {
            do
            {
                number++;
                port.Write("#TARG" + number + "\n");
                message = port.ReadExisting();
                //MessageBox.Show("#TARG" + number + "\n");
                //MessageBox.Show(message, number.ToString());
                
            } while (number <= 3);
           
            if (number == 3)
            {
                number = 1;

            }


        }

        private void SpawnZombie()
        {
            GetPhysicalZombies();
            //for (int i = 1; i <= 2; i++)
            //{
               
                
            //   // MessageBox.Show("test");
            //}
           

        }

        private void timeChecker_Tick(object sender, EventArgs e)
        {
            Healthbar.Value = speler.Levens;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isConnected)
            {
                SpawnZombie();
                timer1.Stop();
            }
           
            
        }
        private void checkDamage()
        {
            // MessageBox.Show(message);
            message = port.ReadExisting();
            if (message != "")
            {
                //int begin = message.IndexOf("$");
                //int end = message.IndexOf("%");
                //string hit = message.Substring(begin, end);
                if (message.Contains("HIT"))
                {
                    //MessageBox.Show("hit");
                    speler.Score += 10;
                }
            }
        }

        private void messageTimer_Tick(object sender, EventArgs e)
        {
                checkDamage();
        }
    }
}
