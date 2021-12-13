using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
//using System.Timers;

namespace Tester
{
    public partial class Form1 : Form
    {
        static string[] zombielijst = { "Ludo", "Sanders", "Jantje" };
        static Random random = new Random();
        Zombie Bigzombie = new Zombie(2, zombielijst[1], "Groot");
        Zombie SmallZombie = new Zombie(1, zombielijst[2], "Klein");
        
        Player speler = new Player("", 3, 0);
        
       
       




        public Form1()
        {
            port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            InitializeComponent();
            connectMetArduino();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            timersnelheid.Start();
            timerMaker.Start();
            test1.Text = "Levens: " + "" + speler.Levens;

            
           
        }

        private void Form1_Load(object sender, EventArgs e) { }
       
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
                //picture.Tag
            }
        }


        void Bigzombie_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            Bigzombie.Health-- ;
            
            label2.Text = $"Score: {speler.Levens}";
            
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



                label2.Text = $"Score: {speler.Levens}";
                SmallZombie.Health = 1;
            }

            

        }
        public void ZombieSnelheid()
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
                            test1.Text = $"Levens: {--speler.Levens}";
                        }
                        else if(speler.Levens <=0 )
                        {
                            gameOver();
                        }
                        

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
            MakeSmallZombie(5, this);
            //target1();
            if(seconden >= 5)
            {
                textBox1.Text = seconden.ToString();
            }
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
            seconden++; 
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
            if (seconden == 5)
            {
                //port.Write("#T1OF\n");
                textBox1.Text = Convert.ToString(seconden);
                seconden = 0;
            }
        }
    }
}
