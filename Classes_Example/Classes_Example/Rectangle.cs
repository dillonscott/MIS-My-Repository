using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example
{
    public class Rectangle
    {

        //private double _Length;
        //public double GetLength()
        //{
        //    return _Length;
        //}

        //public void SetLength(double length)
        //{
        //    _Length = length;

        //}

        public double Length { get; set; }

        public double Width { get; set; }

        /// <summary>
        /// default empty contructor for the Rectangle
        /// Sets values of porperties/attributes to default values
        /// </summary>
        public Rectangle()
        {
            Length = 7; // can use any starting value most typically 0 unless a certain number would make life easier
            Width = 7;
        }


        /// <summary>
        /// overloaded constructer for the rectangle class
        /// Sets properties to the passed in values
        /// </summary>
        /// <param name="length"></param>
        /// <param name="Width"></param>
        public Rectangle(double length, double Width) 
        {
            Length = length;
            this.Width = Width; // if your variable is also uppercase you can use this to specify or just use lowercase variable


        }

        /// <summary>
        /// Calculate the area of this Rectangle instance
        /// </summary>
        /// <returns> The area of the rectangle </returns>
        public double CalculateArea() 
        {

            return Width * Length;

        }

        /// <summary>
        /// Calculate the perimiter of this Rectangle instance
        /// </summary>
        /// <returns> the perimiter of the rectangle</returns>
        public double CalculatePerimiter() 
        {
            return 2 * (Length + Width);

        }


    }
}
