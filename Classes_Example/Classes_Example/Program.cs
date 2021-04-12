using System;

namespace Classes_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create first instance of Rectangle class
            Rectangle rect = new Rectangle();
            rect.Length = 5;
            rect.Width = 5;
            double area = rect.CalculateArea();

            Console.WriteLine($"Rectangle 1: W{rect.Width}, L{rect.Length}, A{area}, P{rect.CalculatePerimiter()}");

            // Second instrance of Rectangle class
            Rectangle rect2 = new Rectangle(25.5, 3.33);

            Console.WriteLine($"Rectangle 2: W{rect2.Width}, L{rect2.Length}, A{rect2.CalculateArea()}, P{rect2.CalculatePerimiter()}");


            // first instance of circle
            Circle circ = new Circle();
            circ.Radius = 3.33;


            Circle circ2 = new Circle();
            circ2.Radius = 9.66;

            Console.WriteLine($"Circle 1: R{circ.Radius}, A{circ.CalculateArea()}, P{circ.CalculatePerimiter()}");
            Console.WriteLine($"Circle 2: R{circ2.Radius}, A{circ2.CalculateArea()}, P{circ2.CalculatePerimiter()}");

        }
    }
}
