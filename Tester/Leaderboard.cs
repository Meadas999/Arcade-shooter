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

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Leaderbord' table. You can move, or remove it, as needed.
            this.leaderbordTableAdapter.Fill(this.testDataSet.Leaderbord);
          
         

        }

        

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.leaderbordTableAdapter.FillBy(this.testDataSet.Leaderbord);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
