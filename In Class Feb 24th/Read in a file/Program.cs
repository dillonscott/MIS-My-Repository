using System;

namespace Read_in_a_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = File.ReadAllText("From the land of the snow pearls.txt");
        }
    }
}
