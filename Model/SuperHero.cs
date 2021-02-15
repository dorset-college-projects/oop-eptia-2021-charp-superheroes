using System;
using System.Collections.Generic;
using System.Text;

namespace SuperHeroe001.Model
{
    public abstract class SuperHero
    {
        public  string power { get; set; }
        public string name { get; set; }

        public SuperHero(string _name, string _power)
        {
            name = _name;
            power = _power;
        }

      
        public override string ToString()
        {
            return $"Super hero: {name}, Power: {power}";

        }
      



    }
}
