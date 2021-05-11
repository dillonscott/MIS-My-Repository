using System;
using System.Collections.Generic;
using System.IO;

namespace _P__Classes___Cereal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = File.ReadAllLines("Cereal_Data (1).txt");

            List<Cereal> cereals = new List<Cereal>();

            for (int i = 1; i < data.Length; i++)
            {
                string onedata = data[i];
                string[] pieces = onedata.Split("|");

                
                //name|manufacturer|calories|cups
                // 0        1           2      3

                Cereal c = new Cereal();
                c.Manufacturer = pieces[1];
                c.Name = pieces[0];
                c.Calories = Convert.ToDouble(pieces[2]);
                c.Cups = Convert.ToDouble(pieces[3]);

                cereals.Add(c);

            }

            Console.WriteLine("\nAll cereals with a serving size of 1 cup or more:");
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Cups >= 1)
                {
                    Console.WriteLine(cereal);
                }
            }

            Console.WriteLine("\nAll cereals with 100 calories or less per serving:");
            foreach (Cereal cereal in cereals)
            {
                if (cereal.Calories <= 100)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(cereal);
                    Console.ResetColor();
                }
            }

        }
    }
}
