using System;

namespace FizzBuzz_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            const string DEVELOPER_INFO = "Dillon Scott";
            Random rand = new Random();
            int randomnumberbetween1and100 = rand.Next(1, 101);
            


            if (randomnumberbetween1and100 % 3 == 0
                && randomnumberbetween1and100 % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (randomnumberbetween1and100 % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (randomnumberbetween1and100 % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(randomnumberbetween1and100);

            }

            Console.WriteLine("Developed by {DEVELOPER_INFO}!");
        }
    }
}
