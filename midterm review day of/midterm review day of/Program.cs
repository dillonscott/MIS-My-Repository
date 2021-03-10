using System;

namespace midterm_review_day_of
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence>>");
            string sentence = Console.ReadLine().ToLower();

            int vowels = 0;
            int consonants = 0;

            

            for (int i = 0; i < sentence.Length; i++)
            {
                char letter = sentence[i];
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter=='o' || letter=='u')
                {
                    vowels++;
                }
                else
                {
                    consonants++;
                }
            }
           

            
            Console.WriteLine($"\tYour sentence has {vowels} vowels.");
            Console.WriteLine($"\tYour sentence has {consonants} consonants.");

        }
    }
}
