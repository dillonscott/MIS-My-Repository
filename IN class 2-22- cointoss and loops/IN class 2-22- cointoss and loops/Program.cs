using System;

namespace IN_class_2_22__cointoss_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Random rand = new Random();
            int randnum = rand.Next(1, 3);
            Console.WriteLine($"{randnum}");

            const int heads = 1;
            const int tails = 2;

            Console.WriteLine("Heads or tails");
            string answer = Console.ReadLine();

            int answerAsInt;

            if (answer.ToLower() == "heads") 
            {
                answerAsInt = heads;
            } 
            else
            {
                answerAsInt = tails;
            }

            if (answerAsInt == randnum)
            {
                Console.WriteLine($"It was {answerAsInt}, You guessed right!");
            }
            else
            {
                Console.WriteLine($"It was {answerAsInt}, Shucks better luck next time");

            }
        }
    }
}
