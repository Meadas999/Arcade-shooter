﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Tester
{
    public class Zombie
    {
        Random rnd = new Random();

        public int Health { get; set; }
        public string Naam { get; private set; }
        public string Type { get; private set; }
        public int Strenght { get; private set; }
        
        public int DodeZombie { get; set; }
        public int LevendeZombie { get; set; }

        
       
        

        
        public Zombie(int health, string naam, string type, int strenght)
        {
            this.Health = health;
            this.Naam = naam;
            this.Type = type;
            
        }

       


        public int WillekeurigeLocatie(int x,int y)
        {
            return rnd.Next(x,y);
        }


        public void LoseHealth(int damage)
        {
            this.Health -= damage;
        }
    }
}
