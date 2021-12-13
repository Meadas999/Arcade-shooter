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
    public partial class GameOver : Form
    {
        Player CurrentPlayer;
        public GameOver(Player currentplayer)
        {
            InitializeComponent();
            this.CurrentPlayer = currentplayer;
        }

        private void naamConfirmBtn_Click(object sender, EventArgs e)
        {
           Player player = new Player(naamConfirmTB.Text);
            Leaderboard leaderboard = new Leaderboard();


            this.Hide();
            leaderboard.ShowDialog();
            this.Close();
            

            
            

        }
    }
}
