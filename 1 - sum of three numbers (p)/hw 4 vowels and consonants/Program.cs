using System;

namespace hw_4_vowels_and_consonants
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a sentence >>");
            string sentence = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;


            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];
                if (letter == 'a' || letter =='e' || letter=='i' || letter=='o' || letter=='u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }

                

            }

            Console.WriteLine($"There were {vowels} vowels in your sentence.");
            Console.WriteLine($"There were {consonants} consonants in your sentence.");
        }
    }
}
