using System;

namespace string_manipulation___participation
{
    class Program
    {
        const string sentence =  "Programming today is a race between software engineers " +
            "striving to build bigger and better idiot-proof programs, and the " +
            "universe trying to build bigger and better idiots. So far, the universe is winning";
        static void Main(string[] args)
        {
            Console.WriteLine(sentence);
            Console.WriteLine($"\nWhat word are you looking for in the above sentence?");
            string lookfor = Console.ReadLine();

            Console.WriteLine($"What do you want to change '{lookfor}' to?");
            string changeto = Console.ReadLine();
            string newsentence;

            if (sentence.Contains(lookfor) == true)
            {
                newsentence = sentence.Replace(lookfor, changeto);
                Console.WriteLine(newsentence);
            }
            else
            {
                Console.WriteLine($"Sorry I could't find '{lookfor}' in the sentence.");
                string reverseword = string.Empty;
                for (int i = lookfor.Length -1; i >= 0; i--)
                {
                    reverseword = reverseword + lookfor[i];
                }

                Console.WriteLine(reverseword);
            }
            
            

            

        }
    }
}
