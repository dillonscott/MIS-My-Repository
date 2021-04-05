using System;

namespace Methods__functions__InClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Please input your grade in the course >>");
                double grade = Convert.ToDouble(Console.ReadLine());

                string lg = ConvertGradeToLetter(grade);

                Console.WriteLine($"Congrats you have a {lg} in the course!");

                Console.WriteLine("Do you want to convert another grade?");
                answer = Console.ReadLine();

            } while (answer.ToLower()[0] == 'y');


        }

        /// <summary>
        /// COnverts a standard grade (i.e. 92.5) to the appropriate letter grade (i.e. 'A')
        /// </summary>
        /// <param name="anyVariableWeWantThisBelongsToThisMEthod"> The grade to convert to a letter</param>
        /// <returns></returns> Returns a string that is the letter grade if the input... N/A if below 0

        static string ConvertGradeToLetter(double anyVariableWeWantThisBelongsToThisMEthod) 
        {
            string lettergrade;
            if (anyVariableWeWantThisBelongsToThisMEthod >= 90)
            {
                lettergrade = "A";
            }
            else if (anyVariableWeWantThisBelongsToThisMEthod >= 80)
            {
                lettergrade = "B";
            }
            else if (anyVariableWeWantThisBelongsToThisMEthod >= 70)
            {
                lettergrade = "C";
            }
            else if (anyVariableWeWantThisBelongsToThisMEthod >= 60)
            {
                lettergrade = "D";
            }
            else if (anyVariableWeWantThisBelongsToThisMEthod >= 0)
            {
                lettergrade = "F";
            }
            else
            {
                lettergrade = "N/A";
            }

            return lettergrade;
        }

    }
}
