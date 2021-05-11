using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___Cereal
{
    public class Cereal
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }

        public Cereal()
        {
            Manufacturer = "";
            Name = "";
            Calories = -10;
            Cups = -10;

        }

        public override string ToString()
        { 
            return ($"{Name} made by {Manufacturer} has {Calories} calories per serving of {Cups} cups.");
        }


    }
}
