using System;

namespace HW1_part2___student_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string ans1 = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string ans2 = Console.ReadLine();

            Console.WriteLine("What is your id number?");
            string ans3 = Console.ReadLine();

            Console.WriteLine("What is your overall percentage grade for homeworks?");
            double hwpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("What is your overall percentage grade for participations?");
            double partpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("What is your overall percentage grade for the midterm?");
            double midtermpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("What is your overall percentage grade for the final?");
            double finalpercent = Convert.ToDouble(Console.ReadLine()) / 100;

            double hw = .12 * hwpercent;
            double participation = .08 * partpercent;
            double midterm = .4 * midtermpercent;
            double final = .4 * finalpercent;
            double grade = hw + participation + midterm + final;


            Console.WriteLine($"{ans1} {ans2} ({ans3}), your final grade is {grade.ToString("P2")}");



           


        }
    }
}
