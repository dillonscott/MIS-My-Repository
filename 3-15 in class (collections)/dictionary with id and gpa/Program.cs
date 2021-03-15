using System;
using System.Collections.Generic;

namespace dictionary_with_id_and_gpa
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> students = new Dictionary<string, double>();
            students.Add("1", 3.0);
            students.Add("2", 4.0);
            students.Add("3", 2.5);

            Console.WriteLine($"Do you want to add another student?");
            string answer = Console.ReadLine();

            if (answer.ToLower()[0] == 'y')
            {
                Console.WriteLine("What is the student's iD?");
                string id = Console.ReadLine();

                Console.WriteLine($"What is the students GPA?");
                double GPA = Convert.ToDouble(Console.ReadLine());
                if (students.ContainsKey(id) == true)
                {
                    Console.WriteLine($"Already contains that key, we will update the GPA for you!");
                    students[id] = GPA;
                }
                else
                {
                    students.Add(id, GPA);
                }
                

            }

            foreach (string id in students.Keys)
            {
                Console.WriteLine(id);
            }

            Console.WriteLine("Whose GPA do you want to see?");
            string seacrhID = Console.ReadLine();

            if (students.ContainsKey(seacrhID) == true)
            {
                Console.WriteLine($"{seacrhID} - {students[seacrhID].ToString("N3")}");
            }
            else
            {
                Console.WriteLine("That student ID does not exist");
            }
           

        }
    }
}
