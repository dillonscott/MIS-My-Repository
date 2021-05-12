using System;

namespace TimeToBurn_HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            const double CALS_per_min = 3.9;
            Console.WriteLine("Hoe many calories do you want to burn this workout?");
            string ans = Console.ReadLine();
            double goal;

            if (double.TryParse(ans, out goal) == false)
            {
                Console.WriteLine("SOrry that was invalid! Goodbye!");
                Environment.Exit(-10);
            }
            double calsSoFar = 0;
            double min = 0;
            do
            {
                Console.WriteLine($"You have burned {calsSoFar.ToString("N2")} calories in {min} minutes!");
                calsSoFar += CALS_per_min;
                min += 1;
            } while (calsSoFar<goal);


        }
    }
}
