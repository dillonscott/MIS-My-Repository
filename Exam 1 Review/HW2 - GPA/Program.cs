using System;

namespace HW2___GPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What was your grade in accounting?");
            double accgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your grade in marketing?");
            double markgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your grade in economics?");
            double econgrade = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What was your grade in MIS?");
            double misgrade = Convert.ToDouble(Console.ReadLine());

            string accletter;
            string markletter;
            string econletter;
            string misletter;
            double pointssofar = 0;
            const double creditsattempted = 12;

            if (accgrade >= 90)
            {
                accletter = "A";
                pointssofar += 12;
                
            }
            else if (accgrade >= 80)
            {
                accletter = "B";
                pointssofar += 9;
            }
            else if (accgrade >= 70)
            {
                accletter = "C";
                pointssofar += 6;
            }
            else if (accgrade >= 60)
            {
                accletter = "D";
                pointssofar += 3;
            }
            else
            {
                accletter = "F";
            }

            if (markgrade >= 90)
            {
                markletter = "A";
                pointssofar += 12;

            }
            else if (markgrade >= 80)
            {
                markletter = "B";
                pointssofar += 9;
            }
            else if (markgrade >= 70)
            {
                markletter = "C";
                pointssofar += 6;
            }
            else if (markgrade >= 60)
            {
                markletter = "D";
                pointssofar += 3;
            }
            else
            {
                markletter = "F";
            }
            if (econgrade >= 90)
            {
                econletter = "A";
                pointssofar += 12;

            }
            else if (econgrade >= 80)
            {
                econletter = "B";
                pointssofar += 9;
            }
            else if (econgrade >= 70)
            {
                econletter = "C";
                pointssofar += 6;
            }
            else if (econgrade >= 60)
            {
                econletter = "D";
                pointssofar += 3;
            }
            else
            {
                econletter = "F";
            }
            if (misgrade >= 90)
            {
                misletter = "A";
                pointssofar += 12;

            }
            else if (misgrade >= 80)
            {
                misletter = "B";
                pointssofar += 9;
            }
            else if (misgrade >= 70)
            {
                misletter = "C";
                pointssofar += 6;
            }
            else if (misgrade >= 60)
            {
                misletter = "D";
                pointssofar += 3;
            }
            else
            {
                misletter = "F";
            }

            double gpa = pointssofar / creditsattempted;

            Console.WriteLine($"Your accounting letter grade is {accletter}");
            Console.WriteLine($"Your marketing letter grade is {markletter}");
            Console.WriteLine($"Your economics letter grade is {econletter}");
            Console.WriteLine($"Your MIS letter grade is {misletter}");
            Console.WriteLine($"\tYour GPA for the semester is {gpa}");






        }
    }
}
