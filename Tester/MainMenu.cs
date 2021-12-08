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
            Leaderboard leaderboard = new Leaderboard();

            this.Hide();
            leaderboard.ShowDialog();
            this.Close();
        }
    }
}
