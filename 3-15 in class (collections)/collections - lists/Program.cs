using System;

namespace collections___lists
{
    class Program
    {
        static void Main(string[] args)
        {
            
            list<string> favoriteThings = new list<string>();

            do
            {
                Console.WriteLine("Name one of your favorite things >>");
                string answer = Console.ReadLine();

                favoriteThings.Add(answer);

                Console.WriteLine("Do you have anotehr favorite thing? >>");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');

            Random rand = new Random();
            int index = rand.Next(0, favoriteThings.Count);

            Console.WriteLine(favoriteThings[index]);
        }
    }
}
