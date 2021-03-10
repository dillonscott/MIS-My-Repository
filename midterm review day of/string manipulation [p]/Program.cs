using System;

namespace string_manipulation__p_
{
    class Program
    {
        static string sentence = "Programming today is a race between software engineers striving to build " +
            "bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. " +
            "So far, the universe is winning.";
        static void Main(string[] args)
        {
            Console.WriteLine("Programming today is a race between software engineers striving to build bigger and better " +
                "idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.");
            Console.WriteLine($"\nWhat word are you looking for in the above sentence?");
            string word = Console.ReadLine();
            Console.WriteLine($"What word do you want to change '{word}' to?");
            string replace = Console.ReadLine();
            string newsentence;

            if (sentence.Contains(word) == false)
            {
                Console.WriteLine($"Sorry I could not find your word, '{word}', in the sentence.");
                string reverse = "";
                for (int i = word.Length-1; i >= 0; i--)
                {
                    reverse = reverse + word[i];
                }
                Console.WriteLine(reverse);

            }
            else
            {
                newsentence = sentence.Replace(word, replace);
                Console.WriteLine(newsentence);
            }
        }
    }
}
