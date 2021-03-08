using System;

namespace guess_a_number___loops___participations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a lower bound >>");
            int lower = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select an upper bound >>");
            int upper = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            int randomnum = rand.Next(lower, upper);

            Console.WriteLine($"Guess a number between {lower} and {upper} >>");
            string guessinput = Console.ReadLine();
            int guess;

            if (int.TryParse(guessinput, out guess) == false)
            {
                Console.WriteLine("Invalid input, goodbye!");
                Environment.Exit(-1);
            }
            else
            {
                while (guess != randomnum)
                {
                    Console.WriteLine($"Guess a number between {lower} and {upper} >>");
                    guess = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Congratulations you got it!");
            }

            
            
        }
    }
}
