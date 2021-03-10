using System;

namespace HW1_salestotal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the name of the product you are purchasing?");
            string product = Console.ReadLine();

            Console.WriteLine($"How many {product}'s do you want to buy?");
            double quantity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"What is the price of one {product}");
            double price = Convert.ToDouble(Console.ReadLine());

            double subtot = quantity * price;
            double tax = subtot * .05;
            double total = subtot + tax;

            Console.WriteLine($"\tYour subtotal for your bill is {subtot}.");
            Console.WriteLine($"\tYour sales tax for your bill is {tax}.");
            Console.WriteLine($"\tYour total for your bill is {total}.");

        }
    }
}
