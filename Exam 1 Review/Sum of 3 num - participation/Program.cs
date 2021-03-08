using System;

namespace Sum_of_3_num___participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first number >>");
            string number1 = Console.ReadLine();
            double num1 = Convert.ToDouble(number1);


            Console.WriteLine("Please enter your second number >>");
            string number2 = Console.ReadLine();
            double num2 = Convert.ToDouble(number2);


            Console.WriteLine("Please enter your third number >>");
            string number3 = Console.ReadLine();
            double num3 = Convert.ToDouble(number3);

            const double multiplier = 7.777;
            double sum = num1 + num2 + num3;
            double product = sum * multiplier;

            Console.WriteLine($"{num1} + {num2} + {num3} = {sum.ToString("N3")}");
            Console.WriteLine($"{sum.ToString("N3")} X {multiplier} = {product.ToString("N3")}");


        }
    }
}
