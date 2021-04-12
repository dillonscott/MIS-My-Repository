using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example
{
    public class Circle
    {
        public double Radius { get; set; }

        public Circle() // type ctor to create a construtor
        {
            Radius = 0;
        }

        public double CalculateArea() 
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculatePerimiter() 
        {
            return 2 * Math.PI * Radius;
        
        }

    }
}
