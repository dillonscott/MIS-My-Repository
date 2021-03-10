using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tuition = 12600;
            for (int i = 1; i <= 7; i++)
            {
                tuition = tuition * 1.05;
                Console.WriteLine($"The tuition after year {i} will be {tuition.ToString("C2")}.");
            }

            
        }
    }
}
