using System;

namespace Participation_in_class_random
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNbr = rand.Next(1,3);
            Console.WriteLine($"{randomNbr}");
        }
    }
}
