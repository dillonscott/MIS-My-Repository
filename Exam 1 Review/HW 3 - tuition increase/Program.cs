using System;

namespace HW_3___tuition_increase
{
    class Program
    {
        static void Main(string[] args)
        {

            double tuition = 12000;
            const double tuitionincrease = .05;

            for (int i = 1; i <= 7 ; i++)
            {
                tuition = tuition * (1 + tuitionincrease);
                Console.WriteLine($"\tThe tuition after year {i} will be {tuition.ToString("C2")}");
            }
            
        }
    }
}
