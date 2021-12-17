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

        private void MakeConnection()
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
        

        private void EndConnection()
        {
            try
            {
                
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
            string selection = "INSERT INTO Test.Leaderbord(Naam, Score) VALUES(@Naam, @Score)";
            MySqlCommand command = new MySqlCommand(selection, this.conn);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Score", score);
           
            command.ExecuteNonQuery();
            EndConnection();
        }

        public void UpdateData(string naam, int score)
        {
            MakeConnection();
            string update = "UPDATE `Leaderbord` SET `Naam`=@Naam,`Score`=@Score WHERE 1";
            MySqlCommand command = new MySqlCommand(update, conn);
            command.Parameters.AddWithValue("@Naam", naam);
            command.Parameters.AddWithValue("@Score", score);
            
            
            
            EndConnection();
        }

        public void GetData()
        {

        }
    }
}
