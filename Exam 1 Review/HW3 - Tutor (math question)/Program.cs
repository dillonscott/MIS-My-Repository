using System;

namespace HW3___Tutor__math_question_
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int left = rand.Next(1, 51);
            int right = rand.Next(1, 51);
            int sum = left + right;
            int ans;

            do
            {
                Console.WriteLine($"\t{left} + {right} = ");
                ans = Convert.ToInt32(Console.ReadLine());

                if (ans != sum)
                {
                    Console.WriteLine("Sorry please try again:");
                }
                

            } while (ans != sum);

            if (ans == sum)
            {
                Console.WriteLine("Congrats, you are correct!");
            }
            
        }
    }
}
