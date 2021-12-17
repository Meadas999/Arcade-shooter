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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void playKnop_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();

            this.Hide();
            game.ShowDialog();
            this.Close();
        }

        private void leaderboardKnop_Click(object sender, EventArgs e)
        {
            Leaderboard Leadrboard = new Leaderboard();

            this.Hide();
            Leadrboard.ShowDialog();
            this.Close();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
