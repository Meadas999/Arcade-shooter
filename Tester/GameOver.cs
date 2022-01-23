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

        private void Key(string letter)
        {
            naamConfirmTB.Text = naamConfirmTB.Text + letter;
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            
        }

        private void q_knop_Click(object sender, EventArgs e)
        {
            Key("Q");
        }

        private void W_knop_Click(object sender, EventArgs e)
        {
            Key("W");
        }

        private void E_knop_Click(object sender, EventArgs e)
        {
            Key("E");
        }

        private void R_knop_Click(object sender, EventArgs e)
        {
            Key("R");
        }

        private void T_knop_Click(object sender, EventArgs e)
        {
            Key("T");
        }

        private void Y_knop_Click(object sender, EventArgs e)
        {
            Key("Y");
        }

        private void U_knop_Click(object sender, EventArgs e)
        {
            Key("U");
        }

        private void I_knop_Click(object sender, EventArgs e)
        {
            Key("I");
        }

        private void O_knop_Click(object sender, EventArgs e)
        {
            Key("O");
        }

        private void P_knop_Click(object sender, EventArgs e)
        {
            Key("P");
        }

        private void A_knop_Click(object sender, EventArgs e)
        {
            Key("A");
        }

        private void S_knop_Click(object sender, EventArgs e)
        {
            Key("S");
        }

        private void D_knop_Click(object sender, EventArgs e)
        {
            Key("D");
        }

        private void F_knop_Click(object sender, EventArgs e)
        {
            Key("F");
        }

        private void G_knop_Click(object sender, EventArgs e)
        {
            Key("G");
        }

        private void H_knop_Click(object sender, EventArgs e)
        {
            Key("H");
        }

        private void J_knop_Click(object sender, EventArgs e)
        {
            Key("J");
        }

        private void K_knop_Click(object sender, EventArgs e)
        {
            Key("K");
        }

        private void L_knop_Click(object sender, EventArgs e)
        {
            Key("L");
        }

        private void Z_knop_Click(object sender, EventArgs e)
        {
            Key("Z");
        }

        private void X_knop_Click(object sender, EventArgs e)
        {
            Key("X");
        }

        private void C_knop_Click(object sender, EventArgs e)
        {
            Key("C");
        }

        private void V_knop_Click(object sender, EventArgs e)
        {
            Key("V");
        }

        private void B_knop_Click(object sender, EventArgs e)
        {
            Key("B");
        }

        private void N_knop_Click(object sender, EventArgs e)
        {
            Key("N");
        }

        private void M_knop_Click(object sender, EventArgs e)
        {
            Key("M");
        }
    }
}
