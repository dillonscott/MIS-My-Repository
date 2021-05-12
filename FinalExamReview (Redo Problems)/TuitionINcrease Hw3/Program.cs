using System;

namespace TuitionINcrease_Hw3
{
    class Program
    {
        static void Main(string[] args)
        {
            double tutition = 12000;
            for (int i = 1; i <= 7; i++)
            {
                tutition = tutition * 1.05;
                Console.WriteLine($"Tuition after year {i} will be {tutition.ToString("C0")} per semester!");

            }
        }
    }
}
