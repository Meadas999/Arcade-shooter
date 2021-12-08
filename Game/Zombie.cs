using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Timers;


namespace Game
{
    class Zombie
    {
        Random random = new Random();
        Form1 form = new Form1();
        private int score = 0;



        public void MakeZombie(int aantal, Form formInstance)
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
            }
        }

        void zombie_Click(object sender, EventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            pic.Visible = false;
            score++;
            form.label2.text = $"score: {score}";
            form.Controls.Remove(pic);
            pic.Dispose();
        }


    }
}
