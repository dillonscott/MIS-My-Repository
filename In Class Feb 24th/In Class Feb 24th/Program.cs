using System;

namespace In_Class_Feb_24th
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += i;
            }

            Console.WriteLine($"All the numbers added up 1 to 100 is {sum.ToString("n2")}");


        }
    }
}
