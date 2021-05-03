using System;
using System.Collections.Generic;
using System.IO;

namespace ShowMeWhatYouLearned_ExtraCredit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] CustomerInfo = File.ReadAllLines("HomeMortgageSample.csv");

            List<Customer> customerList = new List<Customer>();

            //id,first_name,last_name,address,property_cost,mortgage_remaining,interest_rate,date,payment
            // 0      1         2        3           4               5                 6       7     8

            for (int i = 1; i < CustomerInfo.Length; i++)
            {
                string custInfo = CustomerInfo[i];

                string[] pieces = custInfo.Split(',');

                Customer c = new Customer();

                c.CustomerID = Convert.ToInt32(pieces[0]);
                c.FirstName = pieces[1];
                c.LastName = pieces[2];
                c.Address = pieces[3];
                c.PropertyCost = Convert.ToDouble(pieces[4]);
                c.MortgageRemaining = Convert.ToDouble(pieces[5]);
                c.InterestRate = Convert.ToDouble(pieces[6]);
                c.Payments.Add(Convert.ToDateTime(pieces[7]), Convert.ToDouble(pieces[8]));

                customerList.Add(c);

                

            }

            foreach (Customer customers in customerList)
            {
                if (customers.MortgageRemaining > 150000)
                {
                    double totatInt = customers.CalculateInt();
                    Console.WriteLine(customers);
                    Console.WriteLine($"\t{customers.FirstName} {customers.LastName} ({customers.CustomerID}) will pay total interest of {totatInt.ToString("C")}");
                    foreach (double payment in customers.Payments.Values)
                    {
                        Console.WriteLine($"\tMonthly Payment: {payment.ToString("C")}");
                    }

                }
            }

            foreach (Customer customers in customerList)
            {
                if (customers.MortgageRemaining == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n{customers}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            string ans1;
            string ans2;
            Console.WriteLine("\nWould you like to add a new customer?");
            ans1 = Console.ReadLine();
            do
            {
                
                if (ans1[0] == 'y')
                {
                    Console.WriteLine("What is the customers first name?");
                    string fname = Console.ReadLine();

                    Console.WriteLine("What is the customers last name?");
                    string lname = Console.ReadLine();

                    Console.WriteLine("What is the customers address?");
                    string addy = Console.ReadLine();

                    Console.WriteLine("What is the customers property cost?");
                    double cost = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What is the customers interest rate? (In decimal form)");
                    double inRate = Convert.ToDouble(Console.ReadLine());

                    Customer c2 = new Customer();
                    c2.FirstName = fname;
                    c2.LastName = lname;
                    c2.Address = addy;
                    c2.PropertyCost = cost;
                    c2.InterestRate = inRate;
                    c2.CustomerID = customerList.Count + 1;
                    double pmt = cost / 360;
                    c2.Payments.Add(DateTime.Now, pmt);
                    c2.MortgageRemaining = cost;

                    customerList.Add(c2);

                    Console.WriteLine($"{c2.FirstName} {c2.LastName} ({c2.CustomerID}) : {c2.Address} \nProperty Cost: {c2.PropertyCost.ToString("C")} | Mortgage remaining: {c2.MortgageRemaining.ToString("C")} | Interest Rate: {c2.InterestRate.ToString("P")} | Monthly Payment: {pmt.ToString("C")}");

                }
                Console.WriteLine("\nWould you like to add another customer?");
                ans2 = Console.ReadLine();

            } while (ans2[0] == 'y');
            

            Console.WriteLine("\nIs there a specific customer you would like to search for? (Y/N)");
            string ans = Console.ReadLine().ToLower();
            if (ans[0] == 'y')
            {
                Console.WriteLine("\nWhich customers information would you like to see? (Search by customer ID)");
                double searchID = Convert.ToDouble(Console.ReadLine());
                foreach (Customer customers in customerList)
                {
                    if (customers.CustomerID == searchID)
                    {
                        Console.WriteLine($"{customers.FirstName} {customers.LastName} ({customers.CustomerID}) : {customers.Address} \nProperty Cost: {customers.PropertyCost.ToString("C")} | Mortgage remaining: {customers.MortgageRemaining.ToString("C")} | Interest Rate: {customers.InterestRate.ToString("P")}");
                    }
                    
                    
                };

                

            }
            else
            {
                Environment.Exit(-1);
            }

            //foreach (Customer customers in customerList)
            //{
            //    foreach (double payment in customers.Payments.Values)
            //    {
            //        Console.WriteLine($"Monthly Payment: {payment}");
            //    }
            //}

        }
    }
}
