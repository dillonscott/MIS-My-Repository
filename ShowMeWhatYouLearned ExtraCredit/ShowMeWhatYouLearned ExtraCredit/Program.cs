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
            // 0      1         2        3           4               5                 5       7     8

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
                    Console.WriteLine(customers);
                }
            }
        }
    }
}
