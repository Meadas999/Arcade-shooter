using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;

namespace Tester
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void terugKnop_Click(object sender, EventArgs e)
        {
            MainMenu hoofdmenu = new MainMenu();
            this.Hide();
            hoofdmenu.ShowDialog();
            this.Close();

        }
    }
}
