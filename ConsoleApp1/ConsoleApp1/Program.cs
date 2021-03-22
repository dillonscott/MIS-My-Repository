using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many coins do you have total?");
            string ans = Console.ReadLine();

            int coins;

            if (int.TryParse(ans, out coins) == false)
            {
                while (int.TryParse(ans, out coins) == false)
                {
                    Console.WriteLine("That was not a valid amount of coins, please try again >>");
                    ans = Console.ReadLine();
                }
            }

            string cointype;
            double coinvalue;
            double total = 0;


            for (int i = 1; i <= coins; i++)
            {
                Console.WriteLine($"What type of coin is coin number {i}?");
                cointype = Console.ReadLine().ToLower();

                if (cointype == "penny")
                {
                    coinvalue = .01;
                }
                else if (cointype == "nickel")
                {
                    coinvalue = .05;
                }
                else if (cointype == "dime")
                {
                    coinvalue = .10;
                }
                else
                {
                    coinvalue = .25;
                }

                total = total + (coinvalue);
            }


            Console.WriteLine($"\nYou have {total.ToString("C4")} total.");

        }
    }
}
        