using System;

namespace Tutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int rand1 = rand.Next(1,51);
            int rand2 = rand.Next(1, 51);
            double rightAns;
            double guess;

            do
            {
                Console.WriteLine($"{rand1} + {rand2} = ?");
                string ans = Console.ReadLine();
                
                if (double.TryParse(ans, out guess) == false)
                {
                    Console.WriteLine("Sorry that was an invalid guess");
                    Environment.Exit(-1);
                }

                rightAns = rand1 + rand2;

                if (guess == rightAns)
                {
                    Console.WriteLine("Great work!");
                }
                else
                {
                    Console.WriteLine($"Sorry that was incorrect try again!\n{rand1} + {rand2} = ?");
                    ans = Console.ReadLine();
                    if (double.TryParse(ans, out guess) == false)
                    {
                        Console.WriteLine("Sorry that was an invalid guess");
                        Environment.Exit(-1);
                    }
                    if (guess == rightAns)
                    {
                        Console.WriteLine("Great work!");
                    }
                }
            } while (guess != rightAns);

            

        }
    }
}
