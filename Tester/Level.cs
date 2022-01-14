using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class Level
    {
        public int aantalZombies { get; set; }
        public int aantalTanks { get; set; }
        public int tankLevens { get; set; }
        public int targets { get; set; }
        public int snelheid { get; set; } 

        public int level { get; set; }
        
        




        public Level(int aantalZombies, int aantalTank, int tankLevens, int targets, int snelheid )
        {
            this.aantalZombies = aantalZombies;
            this.aantalTanks = aantalTank;
            this.tankLevens = tankLevens;
            this.targets = targets;
            this.snelheid = snelheid;
            this.level = 1;
            
        }

        public void VolgendeLevel()
        {
            this.aantalZombies += 4;
            this.aantalTanks += 1;
            this.tankLevens++;
            this.targets++;
            this.snelheid += 200;
            this.level++;
        }

        public int TotaalZombies()
        {
            int totaal = this.aantalZombies + this.aantalTanks;
            return totaal;
        }
    }
}
