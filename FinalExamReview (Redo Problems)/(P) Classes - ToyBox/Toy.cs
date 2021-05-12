using System;
using System.Collections.Generic;
using System.Text;

namespace _P__Classes___ToyBox
{
    public class Toy
    {
        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes { get; set; }

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = -10;
            Notes = "";
        }
        public string GetAisle() 
        {
            Random rand = new Random();
            int num = rand.Next(1, 25);
            string manufact = Manufacturer.ToUpper();
            string aisle = manufact[0] + num.ToString();
            return aisle;

        }

        public void AddNote(string notes) 
        {
            Notes += "\n" + notes;
        }

        public string GetNotes() 
        {
            return Notes;
        }

        public override string ToString()
        {

            return $"{Name} made by {Manufacturer} cost {Price.ToString("C2")} can be found on aisle {GetAisle()}. {GetNotes()}";
        }
    }
}
