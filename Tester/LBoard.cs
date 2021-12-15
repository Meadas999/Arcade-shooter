using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace Tester
{
    class LBoard
    {
        private static string connectionString = "Server=192.168.52.50;Port=3306;Uid=Arcade;Database=Test;Pwd=Arcade-61";
        private MySqlConnection conn;

        public string Naam { get; private set; }
        public int Score { get; set; }
        public int Accuracy { get; set; }

        public LBoard(int score, string naam, int accuracy)
        {
            this.Naam = naam;
            this.Score = score;
            this.Accuracy = accuracy;

        }

        public LBoard()
        { }

        public void MakeConnection()
        {
            try
            {
                this.conn = new MySqlConnection(connectionString);
                this.conn.Open();
                Console.WriteLine("Connected");

            }

            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }


        }
        

        public void EndConnection()
        {
            try
            {
                this.conn = new MySqlConnection(connectionString);
                this.conn.Close();
                Console.WriteLine("Disconnected");

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        public void InsertData(string naam, int score)
        {
            MakeConnection();
            string selection = "insert into Leaderbord values (@Naam, @Score)"
            MySqlCommand command = new MySqlCommand(selection, conn);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Score", score);
            command.ExecuteNonQuery();
            EndConnection();
        }

        public void UpdateData()
        {
            MakeConnection();
            string update = "Update Leaderbord set Naam = @Naam, Score = @Score";
            MySqlCommand Update = new MySqlCommand()


            EndConnection();
        }

    }
}
