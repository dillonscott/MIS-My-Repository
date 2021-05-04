using System;

namespace _P__Functions___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Dillon Scott", "Intro to Prog", "May the 4th");
            string ans1;
            double result;
            double val1;
            double val2;
            string calc;

            do
            {
                Console.WriteLine("What kind of calculation do you want to perform? (Add, Subtract, Divide, Multiply)");
                calc = Console.ReadLine().ToLower();

                Console.WriteLine("What is the first value you want to use?");
                val1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What is the second value you want to use?");
                val2 = Convert.ToDouble(Console.ReadLine());
                
                if (calc == "add")
                {
                    result = Add(val1, val2);
                    Console.WriteLine($"{val1} + {val2} = {result}");
                }
                else if (calc == "subtract")
                {
                    result = Subtract(val1, val2);
                    Console.WriteLine($"{val1} - {val2} = {result}");
                }
                else if (calc == "multiply")
                {
                    result = Multiply(val1, val2);
                    Console.WriteLine($"{val1} X {val2} = {result}");

                }
                else
                {
                    result = Divide(val1, val2);
                    Console.WriteLine($"{val1} / {val2} = {result}");
                }
               

                Console.WriteLine("Would you like to do another calculation?");
                ans1 = Console.ReadLine().ToLower();

                Console.WriteLine("What calculation would you like to perform? (Add, Subtract, Divide, Multiply)");
                calc = Console.ReadLine().ToLower();

                Console.WriteLine("Would you like to use the result of the previous calculation as one of your values?");
                string ans2 = Console.ReadLine().ToLower();

                if (ans2[0] == 'y')
                {
                    Console.WriteLine("What is the second value you'd like to use?");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    
                    if (calc == "add")
                    {
                        double sum1 = Add(result, val2);
                        Console.WriteLine($"{result} + {val2} = {sum1}");
                    }
                    else if (calc == "subtract")
                    {
                        double diff = Subtract(result, val2);
                        Console.WriteLine($"{result} - {val2} = {diff}");
                    }
                    else if (calc == "multiply")
                    {
                        double prod = Multiply(result, val2);
                        Console.WriteLine($"{result} X {val2} = {prod}");

                    }
                    else if (calc == "divide")
                    {
                        double div = Divide(result, val2);
                        Console.WriteLine($"{result} / {val2} = {div}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry I cannot perform that calculation");
                        Environment.Exit(-1);
                    }

                }
                else
                {
                    Console.WriteLine("What is the first value you'd like to use?");
                    val1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("What is the second value youd like to use?");
                    val2 = Convert.ToDouble(Console.ReadLine());

                    if (calc == "add")
                    {
                        result = Add(val1, val2);
                        Console.WriteLine($"{val1} + {val2} = {result}");
                    }
                    else if (calc == "subtract")
                    {
                        result = Subtract(val1, val2);
                        Console.WriteLine($"{val1} - {val2} = {result}");
                    }
                    else if (calc == "multiply")
                    {
                        result = Multiply(val1, val2);
                        Console.WriteLine($"{val1} X {val2} = {result}");

                    }
                    else if (calc == "divide")
                    {
                        result = Divide(val1, val2);
                        Console.WriteLine($"{val1} / {val2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry I cannot perform that calculation");
                        Environment.Exit(-1);
                    }

                    

                }
                Console.WriteLine("Would you like to perform another calculation?");
                ans1 = Console.ReadLine().ToLower();
            } while (ans1[0] == 'y');
            
                
            

            Console.WriteLine("Thank you for using the application, hoe!");
            
        }


        static double Add(double val1, double val2) 
        {
            double result = val1 + val2;
            return result;
        }
        static double Subtract(double val1, double val2) 
        {
            double rsult = val1 - val2;
            return rsult;

        }
        static double Multiply(double val1, double val2) 
        {
            double result = val1 * val2;
            return result;

        }
        static double Divide(double val1, double val2) 
        {
            double result = val1 / val2;
            return result;

        }
        static void DeveloperInformation(string devName, string className, string date) 
        {
            Console.WriteLine($"{devName} developed this for {className} on {date}");
        }

    }

}
