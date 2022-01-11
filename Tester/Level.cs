﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class Level
    {
        public int aantalZombies { get; set; }
     
        public int tankLevens { get; set; }
        public int targets { get; set; }
        public int snelheid { get; set; } 
        public int nodigeScore { get; set; }




        public Level(int aantalZombies, int tankLevens, int targets, int snelheid, int nodigeScore)
        {
            this.aantalZombies = aantalZombies;
           
            this.tankLevens = tankLevens;
            this.targets = targets;
            this.snelheid = snelheid;
            this.nodigeScore = nodigeScore;
        }

        public void nextLevel()
        {
            this.aantalZombies += 4;
            this.nodigeScore += 5;
            this.tankLevens++;
            this.targets++;
            this.snelheid += 200;
        }
    }
}
