using System;

namespace _P__Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a type of animal");
            string animal = Console.ReadLine().ToLower();

            Console.WriteLine($"A {animal} makes the sound {Speak(animal)}");



        }

        static string Speak (string animal) 
        {
            string sound;

            if (animal == "dog")
            {
               sound = "Woof";
            }
            else if (animal == "cow")
            {
                sound = "MOOOOOOO";
            }
            else if (animal == "horse")
            {
                sound = "Neighhhhh";
            }
            else
            {
                sound = "GLOGLOGOMDP";
            }


            return sound;
        }

      
    }
}
