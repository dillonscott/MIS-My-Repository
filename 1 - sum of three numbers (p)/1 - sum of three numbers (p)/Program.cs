using System;

namespace _1___sum_of_three_numbers__p_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number >>");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your second number >>");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter your third number >>");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double sum = num1 + num2 + num3;

            Console.WriteLine($"{num1} + {num2} + {num3} = {sum}");

        }
    }
}
