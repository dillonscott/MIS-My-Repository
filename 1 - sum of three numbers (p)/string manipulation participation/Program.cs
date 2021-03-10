using System;

namespace string_manipulation_participation
{
    class Program
    {
        static string message = "Programming today is a race between software engineers striving to build bigger and better " +
            "idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better idiot - proof programs, and the universe trying to build bigger and better idiots.So far, the universe is winning.");

            Console.WriteLine("\nWhat word are you looking for in the above sentence?");
            string word = Console.ReadLine();

            Console.WriteLine("What word do you want to replace it with?");
            string newword = Console.ReadLine();

            string newmessage = "";
            string reverse = "";


            if (message.Contains(word) == true)
            {
               newmessage = message.Replace(word, newword);
                Console.WriteLine(newmessage);
            }
            else
            {
                Console.WriteLine($"Sorry I could not find your word, '{word}'.");
                for (int i = word.Length -1 ; i >= 0; i--)
                {
                    reverse = reverse + word[i];
                }
                Console.WriteLine(reverse);
            }
            
            
        }
    }
}
