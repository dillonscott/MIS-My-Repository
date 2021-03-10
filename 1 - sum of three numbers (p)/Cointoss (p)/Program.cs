using System;

namespace Cointoss__p_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heads or Tails?");
            string ans = Console.ReadLine().ToLower();

            Random rand = new Random();
            int toss = rand.Next(0, 2);

            string coin;

            if (toss == 0)
            {
                coin = "heads";
            }
            else
            {
                coin = "tails";
            }
            if (ans == coin)
            {
                Console.WriteLine($"You were right, it was {coin}!");
            }
            else
            {
                Console.WriteLine($"That's wrong, you suck, it was {coin}.");
            }
            
        }
    }
}
