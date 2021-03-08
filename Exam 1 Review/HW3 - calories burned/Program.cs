using System;

namespace HW3___calories_burned
{
    class Program

    {
        const double Calories_per_min = 3.9;
        static void Main(string[] args)
        {
            Console.WriteLine("How many calories would you like to burn?");
            string ans = Console.ReadLine();

            int minutes = 0;
            double caloriesBurned = 0;
            double goal;

          

            if (double.TryParse(ans, out goal) == false)
            {
                Console.WriteLine("INVALID INPUT, GOODBYE.");
                Environment.Exit(-1);
            }

            if (goal == 0)
            {
                Console.WriteLine("Come on you can do better than that!");
            }
            
            
            while (caloriesBurned < goal)
            {
                minutes++;
                caloriesBurned = caloriesBurned + Calories_per_min;
                Console.WriteLine($"After {minutes} minutes you have burned {caloriesBurned.ToString("N2")} calories.");
            }
            


            

            
        }
    }
}
