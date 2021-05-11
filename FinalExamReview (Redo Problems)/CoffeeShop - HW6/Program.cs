using System;
using System.Collections.Generic;

namespace CoffeeShop___HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMenu());
            List<double> OrderHistory = new List<double>();
            

            string ans;
            do
            {
                Console.WriteLine("What would you like to order?");
                string item = Console.ReadLine();

                double price = CalculatePrice(item);
                OrderHistory.Add(price);

                ShowReceipt(price);


                Console.WriteLine($"\nWould you like to order anything else? (Yes/No)");
                ans = Console.ReadLine().ToLower();


            } while (ans[0] == 'y');


            double subtot = 0;
            for (int i = 0; i < OrderHistory.Count; i++)
            {
                
                subtot += OrderHistory[i];

            }
            
            Console.WriteLine("\nThe totals for all of your items are as follows:");
            ShowReceipt(subtot);
            





            static string GetMenu() 
            {
                string menu;

                menu = "Coffee Shop Menu \n" +
                    "Fresh Coffee ---- $2.25\n" +
                    "Cafe au lait ---- $3.72\n" +
                    "Latte ----------- $4.03\n" +
                    "Hot Chocolate --- $3.51\n" +
                    "Pumpkin Spice --- #7.30";


                return menu;
            }

            static double CalculatePrice(string item)
            {
                double price;
                if (item.ToLower() == "fresh coffee")
                {
                    price = 2.25;
                }
                else if (item.ToLower() == "cafe au lait")
                {
                    price = 3.72;
                }
                else if (item.ToLower() == "latte")
                {
                    price = 4.03;
                }
                else if (item.ToLower() == "hot chocolate")
                {
                    price = 3.51;
                }
                else if (item.ToLower() == "pumpkin spice")
                {
                    price = 7.30;
                }
                else
                {
                    price = 0;
                    Console.WriteLine("Sorry that item is not on the menu!");
                }


                return price;

            }

            static void ShowReceipt (double price)
            {
                double subtot = price;
                double tax = subtot * .085;
                double total = subtot + tax;

                Console.WriteLine($"Subtotal:    {subtot.ToString("C")}\n" +
                                  $"Tax:         {tax.ToString("C")}\n" +
                                  $"Total:       {total.ToString("C")}");
            
            
            
            }



        }
    }
}
