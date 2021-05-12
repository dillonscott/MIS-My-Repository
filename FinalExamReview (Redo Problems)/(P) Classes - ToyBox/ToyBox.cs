using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___ToyBox
{
    class ToyBox
    {
        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }
        public string Location { get; set; }

        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = "";
            Location = "";
        }

        public Toy GetRandomToy() 
        {
            Random rand = new Random();
            int index = rand.Next(0, Toys.Count);

            return Toys[index];
        }

    }
}
