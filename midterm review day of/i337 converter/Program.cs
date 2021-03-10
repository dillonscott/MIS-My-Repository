using System;

namespace i337_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sentence >>");
            string sentence = Console.ReadLine().ToUpper();

            string newsentence;

            newsentence = sentence.Replace('A', '4').Replace('E', '3').Replace("H", "|-|")
                .Replace('S', '$').Replace('T', '7').Replace("U", "|_|").Replace('O', '0').Replace("P", "[]D");

            if (newsentence[newsentence.Length-1] != '!')
            {
                newsentence = newsentence + '!';
            }
            Console.WriteLine(newsentence);
        }
            

    }
}
