using System;

namespace hw3_tutor_math_problem_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int left = rand.Next(1, 51);
            int right = rand.Next(1, 51);

            Console.WriteLine($"\t{left} + {right} = ?");
            string ans = Console.ReadLine();
            int guess;
            int sum = left + right;

            do
            {
                if (int.TryParse(ans, out guess) == false)
                {
                    Console.WriteLine($"INVALID INPUT. GOODBYE.");
                    Environment.Exit(-1);
                }
                else
                {
                    Console.WriteLine("Please guess again >>");
                    Console.WriteLine($"\t{left} + {right} = ?");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            } while (guess != sum);

            Console.WriteLine($"Congrats! It was {sum}");
            


        }
    }
}
