using System;
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
    class Zombie
    {
        public int Health { get; set; }
        public string Naam { get; private set; }
        public string Type { get; private set; }
        

        
        
        public Zombie(int health, string naam, string type)
        {
            this.Health = health;
            this.Naam = naam;
            this.Type = type;
            

            
        }

        public int Attack()
        {
            ; 
        }

        public void LoseHealth(int damage)
        {
            this.Health -= damage;
        }
    }
}
