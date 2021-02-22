using System;

namespace Loops_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
         
        }
        private static void WhileExample()
        {
            int favoriteNumber;
            Console.WriteLine("What's your favorite number? >>");
            string answer = Console.ReadLine();

            while (int.TryParse(answer, out favoriteNumber) == false)
            {
                Console.WriteLine("INcorrect value. you must enter an integer");
                answer = Console.ReadLine();

            }
        }
    }
}
