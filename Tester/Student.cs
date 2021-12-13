using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Student
    {
        public string Naam { get; private set; }
        public int Leeftijd { get; set; }
        public int Studentnummer { get; private set; }

        public Student(string naam, int leeftijd)
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;

        }

        public Student(string naam, int leeftijd, int studentnummer) 
        {
            this.Naam = naam;
            this.Leeftijd = leeftijd;
            this.Studentnummer = studentnummer;

        }
    }
}
