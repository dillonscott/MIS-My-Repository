using System;

namespace guess_a_number_participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a lower bound >>");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter an upper bound >>");
            int upper = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int num = rand.Next(lower, upper);

            Console.WriteLine($"Guess a number bewteen {lower} and {upper}");
            string ans = Console.ReadLine();

            int guess;

            if (int.TryParse(ans, out guess) == false)
            {
                Console.WriteLine("INVALID GUESS, GOODBYE!");
                Environment.Exit(-1);
            }
            else
            {
                while (guess != num)
                {
                    Console.WriteLine($"Sorry that's wrong, please guess again!");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("You got it right!");
            }
            
            

            


        }
    }
}
