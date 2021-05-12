using System;
using System.Collections.Generic;

namespace _P__Classes___ToyBox
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans1;

            string ans;
            List<ToyBox> toyBoxes = new List<ToyBox>();

            do
            {
                

                Console.WriteLine("Who is the owner of the toybox?");
                string owner = Console.ReadLine();

                Console.WriteLine("Where is the toybox located?");
                string location = Console.ReadLine();

                ToyBox tb = new ToyBox();
                tb.Owner = owner;
                tb.Location = location;

                toyBoxes.Add(tb);

                Console.WriteLine("Would you like to add a toybox?");
                ans = Console.ReadLine().ToLower();

            } while (ans[0] == 'y');

            
            
            foreach (ToyBox tb in toyBoxes)
            {
                Console.WriteLine($"Let's add to {tb.Owner}'s toybox");

                do
                {
                    

                    Console.WriteLine("Who manufactured the toy?");
                    string manufact = Console.ReadLine();

                    Console.WriteLine("What is the name of the toy?");
                    string name = Console.ReadLine();

                    Console.WriteLine("How much did the toy cost?");
                    double price = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Are there any notes about this toy?");
                    string ans2 = Console.ReadLine().ToLower();
                    string notes;
                    if (ans2[0] == 'y')
                    {
                        Console.WriteLine("What notes do you have?");
                        notes = Console.ReadLine();
                    }
                    else
                    {
                        notes = "";
                    }
                    Toy t = new Toy();
                    t.Manufacturer = manufact;
                    t.Name = name;
                    t.Price = price;
                    t.AddNote(notes);

                    tb.Toys.Add(t);

                    Console.WriteLine("Do you want to add another toy?");
                    ans1 = Console.ReadLine().ToLower();

                } while (ans1[0] == 'y');
            }

            foreach (ToyBox tb in toyBoxes)
            {
                Console.WriteLine($"{tb.Owner}'s toybox contents:");
                foreach (Toy toy in tb.Toys)
                {
                    Console.WriteLine(toy);
                }
            }

            foreach (ToyBox tb in toyBoxes)
            {
                tb.GetRandomToy();
            }

            





            
            
        }
    }
}
