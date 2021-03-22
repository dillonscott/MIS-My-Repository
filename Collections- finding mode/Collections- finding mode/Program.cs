using System;
using System.Collections.Generic;

namespace Collections__finding_mode
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;

            List<double> examScores = new List<double>();
            Dictionary<double, int> exams = new Dictionary<double, int>();

            do
            {
                Console.WriteLine("Enter your exam score >>");
                answer = Console.ReadLine();

                double score = Convert.ToDouble(answer); // assumeing user knows what theyre doing
                examScores.Add(score); //store value in collection to access later

                Console.WriteLine("Do you have another exam score to ender, yes or no? ");
                answer = Console.ReadLine();


            } while (answer.ToLower()[0] == 'y');

            double min = examScores[0];

            foreach (double score in examScores)
            {
                if (score < min)
                {
                    min = score;
                }

                if (exams.ContainsKey(score) == true)
                {
                    exams[score] = exams[score] + 1;
                }
                else
                {
                    exams.Add(score, 1);
                }

            }

            Console.WriteLine($"Your min score was {min.ToString("n2")}");
            int mode = 0;
            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] > mode)
                {
                    mode = exams[scoreKey];
                }
            }

            foreach (double scoreKey in exams.Keys)
            {
                if (exams[scoreKey] == mode)
                {
                    Console.WriteLine($"{exams[scoreKey]} occurs the most");
                }
            }
        }
    }
}
