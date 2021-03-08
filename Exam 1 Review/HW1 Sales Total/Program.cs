using System;

namespace HW1_Sales_Total
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of item are you purchasing?");
            string item = Console.ReadLine();

            Console.WriteLine($"How many {item}'s are you purchasing?");
            string answer = Console.ReadLine();
            int quant = Convert.ToInt32(answer);

            Console.WriteLine($"How much does each {item} cost?");
            string ans2 = Console.ReadLine();
            double price = Convert.ToDouble(ans2);

            double subtot = quant * price;
            double salestax = subtot * .085;
            double total = subtot + salestax;

            Console.WriteLine($"\tYour subtotal for your bill is {subtot.ToString("C2")}");
            Console.WriteLine($"\tYour sales tax for your bill is {salestax.ToString("C2")}");
            Console.WriteLine($"\tYour total for your bill is {total.ToString("C2")}");




        }
    }
}
