using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class LBoard
    {
        public string Naam { get; private set; }
        public int Score { get; set; }
        public int Accuracy { get; set; }

        public LBoard(int score, string naam, int accuracy)
        {
            this.Naam = naam;
            this.Score = score;
            this.Accuracy = accuracy;

        }





    }
}
