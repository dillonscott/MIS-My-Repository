using System;
using System.Collections.Generic;

namespace HW8_ClassesExtended
{
    public class Patient
    {
        public string FirstName { get; set; }
        public char MidInitial { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public bool FluVaccineYN { get; set; }
        public Dictionary<DateTime, double> Weights { get; set; }
        public List<string> Perscriptions { get; set; }

        public Patient()
        {
            FirstName = "";
            MidInitial = '\0';
            LastName = "";
            ID = -10;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            Perscriptions = new List<string>();

        }
        public Patient(int patID)
        {
            FirstName = "";
            MidInitial = '\0';
            LastName = "";
            ID = patID;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            Perscriptions = new List<string>();
        }
        public Patient(string firstName, char midin, string lastName)
        {
            FirstName = firstName;
            MidInitial = midin;
            LastName = lastName;
            ID = -10;
            FluVaccineYN = false;
            Weights = new Dictionary<DateTime, double>();
            Perscriptions = new List<string>();
        }

        public override string ToString()
        {
            string vaxYN;
            if (FluVaccineYN)
            {
                vaxYN = "True";
            }
            else
            {
                vaxYN = "False";
            }
            return $"{LastName}, {FirstName} {MidInitial}. ({ID}) Flu Vaccine: {vaxYN}";
        }

        public double CalculateMaxWeight() 
        {
            double max = -10;
            foreach (double weight in Weights.Values)
            {
                if (weight > max)
                {
                    max = weight;
                }

            }
            return max;
        }

        public void DisplayMedicine() 
        {
            foreach (string med in Perscriptions)
            {
                Console.WriteLine(med);
            }
        
        }

        public void AdministerVaccine() 
        {
            if (FluVaccineYN)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The patient has already been administered the vaccine!");
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Give this bitch the vaccine!");
                Console.ResetColor();
                FluVaccineYN = true;
            }
        }

        public void PerscribeMedicine(string med) 
        {
            Perscriptions.Add(med);
        }
    }
}
