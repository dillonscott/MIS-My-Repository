using System;

namespace HW2_Trivia_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am going to do great on this exam. (T/F)");
            string ans = Console.ReadLine().ToUpper();

           double score = 0;

            if (ans == "T")
            {
                score++;
            }

            Console.WriteLine("I am studying hard. (T/F)");
            string ans2 = Console.ReadLine().ToUpper();

            if (ans2 == "T")
            {
                score++;
            }

            Console.WriteLine("I will not fail. (T/F)");
            string ans3 = Console.ReadLine().ToUpper();

            if (ans3 == "T")
            {
                score++;
            }

            Console.WriteLine("I will not eat until this test. (T/F)");
            string ans4 = Console.ReadLine().ToUpper();

            if (ans4 == "F")
            {
                score++;
            }

            Console.WriteLine("I am going to quit drinking water forever. (T/F)");
            string ans5 = Console.ReadLine().ToUpper();

            if (ans5 == "F")
            {
                score++;
            }

            double grade = score / 5;


            Console.WriteLine($"You got {score} / 5 questions correct! That's {grade.ToString("p2")}");


        }
    }
}
