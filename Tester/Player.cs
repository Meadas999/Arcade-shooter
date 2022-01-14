using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
   public class Player
    {
        public string Naam {get; set;} 
        public int Levens { get; set; }
        public int Score { get; set; }
        

        public Player(string naam, int levens, int score)
        {
            this.Naam = naam;
            this.Levens = levens;
            this.Score = score;

        }

        public Player(string naam)
        {
            this.Naam = naam;        
        }

        


    }
}
