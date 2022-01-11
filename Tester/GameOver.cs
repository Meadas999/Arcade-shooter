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
           CurrentPlayer.Naam = naamConfirmTB.Text;
           Leaderboard leaderboard = new Leaderboard();
           LBoard leaderKlasse = new LBoard();
           
            MessageBox.Show(CurrentPlayer.Naam + " " + "Score:" + Convert.ToString(CurrentPlayer.Score));
            leaderKlasse.InsertData(CurrentPlayer.Naam, CurrentPlayer.Score);
            leaderKlasse.UpdateData(CurrentPlayer.Naam, CurrentPlayer.Score);
            this.Hide();
            leaderboard.ShowDialog();
            this.Close();
            

            
            

        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }
    }
}
