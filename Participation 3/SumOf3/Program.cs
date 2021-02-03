using System;

namespace SumOf3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            const double MAGIC_NUMBER = 7.777; //Local variable that is a constant 

            double heresMyDouble;
            double heresMyDoubleTwo;
            double heresMyDoubleThree;

            Console.WriteLine($"Please enter a number >>");
            string answer = Console.ReadLine();
            heresMyDouble = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter a second number >>");
            answer = Console.ReadLine();
            heresMyDoubleTwo = Convert.ToDouble(answer);

            Console.WriteLine($"Please enter a third double >>");
            answer = Console.ReadLine();
            heresMyDoubleThree = Convert.ToDouble(answer);

            double result = heresMyDouble + heresMyDoubleTwo + heresMyDoubleThree;

            Console.WriteLine("The sum of your numbers is " + result.ToString("N3"));

            double product = result * MAGIC_NUMBER;

            Console.WriteLine(result.ToString("N3") + " times 7.777 = " + product);


        }
    }
}
