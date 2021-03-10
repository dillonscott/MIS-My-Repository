using System;

namespace HW3_time_to_burn_calories
{
    class Program
    {
        const double calspermin = 3.9;
        static void Main(string[] args)
        {
            Console.WriteLine("How many calories do you want to burn this session?");
            string ans = Console.ReadLine();

            double cals;
            int min = 1;
            double calsburned = 0;

            if (double.TryParse(ans, out cals) == false)
            {
                Console.WriteLine("INVALID INPUT. GOODBYE.");
                Environment.Exit(-1);
            }
            else
            {
                while (calsburned < cals)
                {
                    min++;
                    calsburned = calsburned + calspermin;
                    Console.WriteLine($"After {min} minutes, you have burned {calsburned.ToString("N2")} calories.");
                }
            }
        }
    }
}
