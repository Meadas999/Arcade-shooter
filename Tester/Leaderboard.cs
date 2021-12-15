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
using MySql.Data;

namespace Tester
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }


        LBoard leaderboardK = new LBoard();

        private void terugKnop_Click(object sender, EventArgs e)
        {
            MainMenu hoofdmenu = new MainMenu();
            this.Hide();
            hoofdmenu.ShowDialog();
            this.Close();

        }

        private void MakeConnection_Click(object sender, EventArgs e)
        {
            leaderboardK.MakeConnection();
        }

        private void CloseConnectionBTN_Click(object sender, EventArgs e)
        {
            leaderboardK.EndConnection();
        }
    }
}
