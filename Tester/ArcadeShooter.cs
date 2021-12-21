using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class Level
    {
        public int naamLevel { get; set; }
        public int aantalZombies { get; set; }
        public int aantalTanks { get; set; }
        public int tankLevens { get; set; }
        public int targets { get; set; }
        public int Snelheid { get; set; }

        private static int volgendeLevel = 1; 

        public Level(int aantalZombies, int aantalTanks, int tankLevens, int targets, int snelheid)
        {
            this.aantalZombies = aantalZombies;
            this.aantalTanks = aantalTanks;
            this.tankLevens = tankLevens;
            this.targets = targets;
            this.Snelheid = snelheid;
            this.naamLevel = volgendeLevel;
            volgendeLevel++;
        }

        public void VolgendeLevel()
        {
            this.naamLevel++;
            this.aantalZombies += 4;
            this.aantalTanks += 2;
            this.tankLevens++;
            this.targets++;
        }
    }
}
