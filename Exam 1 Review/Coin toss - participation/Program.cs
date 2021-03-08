using System;

namespace Coin_toss___participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Heads or Tails?");
            string ans = Console.ReadLine().ToLower();

            Random rand = new Random();
            int num = rand.Next(1, 3);
            string coin;

            if (num == 1)
            {
                coin = "heads";
            }
            else
            {
                coin = "tails";
            }
            if (ans == coin)
            {
                Console.WriteLine($"You're right, it's {coin}");
            }
            else
            {
                Console.WriteLine($"Sorry it was {coin}");
            }


        }
    }
}
