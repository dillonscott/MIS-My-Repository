using System;
using System.Collections.Generic;
using System.Text;

namespace ShowMeWhatYouLearned_ExtraCredit
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double PropertyCost { get; set; }
        public double MortgageRemaining { get; set; }
        public double InterestRate { get; set; }
        public Dictionary<DateTime, double> Payments { get; set; }

        public Customer()
        {
            CustomerID = -20;
            FirstName = string.Empty;
            LastName = string.Empty;
            Address = string.Empty;
            PropertyCost = 0;
            MortgageRemaining = -50;
            InterestRate = 0;
            Payments = new Dictionary<DateTime, double>();


        }

        public override string ToString()
        {
            string instance = $"{LastName}, {FirstName} ({CustomerID}): Remaining Mortgage Value: {MortgageRemaining.ToString("C")}";
            return instance;
        }

        public double CalculateInt() 
        {
            double totalInt;

            totalInt = PropertyCost * InterestRate;

            return totalInt;

        }

      
        

    }
}
