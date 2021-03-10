using System;

namespace HW_1_StudentGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("What is your ID number?");
            double id = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double hwpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("What is your overall percentage grade for participations?");
            double partpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("What is your overall percentage grade for the final?");
            double finalpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            double hwgrade = .12 * hwpercent;
            double partgrade = .08 * partpercent;
            double midgrade = .4 * midpercent;
            double finalgrade = .4 * finalpercent;
            double grade = hwgrade + partgrade + midgrade + finalgrade;

            Console.WriteLine($"{firstname} {lastname} ({id}), your final grade is {grade.ToString("p2")}");

        }
    }
}
