using System;

namespace In_Class_Feb._8
{
    class Program
    {
        static void Main(string[] args)
        {
       
            

            Console.WriteLine($"Please enter your favorite number (whole # only!) >>");
            //int luckynumber = Convert.ToInt32(Console.ReadLine());
            string answer = Console.ReadLine();
            int luckynumber;
            bool isInteger = int.TryParse(answer, out luckynumber);

            if (isInteger == false)
            {
                Console.WriteLine($"{answer} was not a valid integer, Goodbye!");
                // return; this is another way to exit the code
                Environment.Exit(-1);
            }

           

            luckynumber = Convert.ToInt32(answer);
            int remainder = luckynumber % 7;

            if (remainder == 0)
            {
                Console.WriteLine($"{luckynumber} is truly a lucky number!");
            }
            else if (luckynumber % 13 == 0)
            {
                Console.WriteLine($"{luckynumber} is really an unlucky number!");
             }
            else
            {
                Console.WriteLine($"{luckynumber}");
            }

            Console.WriteLine("What is your favorite type of pet >>");
            answer = Console.ReadLine();

            switch (answer.ToLower())

            {
                case "dog":
                    Console.WriteLine("Cool me too");
                    break;
                case "cat":
                    Console.WriteLine("If you say so");
                    break;
            
                default:
                    Console.WriteLine($"Who would ever have a pet {answer}");
                    break;
            }
        }

        }
    }

