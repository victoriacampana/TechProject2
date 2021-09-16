// Name: Maria Victoria Campana
// Project: Tech Project #2
// Description: Assining a letter grade based on their expected number grade
// Date Due: September 16, 2021 

using System;

namespace TechProject2_Campana
{

    class MainClass
    {
        public static void Main(string[] args)
        {
            // Adding text related to what you want them to input
            Console.WriteLine("What number grade do you expect to get in ISM 4300?");

            // Try Catch allows any potential errors to be caught and fixed from input of student
            try
            {

                // Space for student to input their expected number grade
                // Display of phrase with number grade
                string inputdata = Console.ReadLine();
                int inputgrade = int.Parse(inputdata);
                if (inputgrade < 0 || inputgrade > 100)
                {
                    Console.WriteLine("Please enter a grade between 0 - 100");
                    Console.WriteLine("Please exit the program and try again");
                }


                // Converting number grade into letter grade for student's expected grade 

                if (inputgrade <= 100 && inputgrade >= 93)
                    Console.WriteLine("You're expected to get an A in ISM 4300");
                else
                    if (inputgrade <= 92 && inputgrade >= 90)
                    Console.WriteLine("You're expected to get an A- in ISM 4300");
                else
                    if (inputgrade <= 89 && inputgrade >= 87)
                    Console.WriteLine("You're expected to get an B+ in ISM 4300");
                else
                    if (inputgrade <= 86 && inputgrade >= 83)
                    Console.WriteLine("You're expected to get an B in ISM 4300");
                else
                    if (inputgrade <= 82 && inputgrade >= 80)
                    Console.WriteLine("You're expected to get an B- in ISM 4300");
                else
                    if (inputgrade <= 79 && inputgrade >= 77)
                    Console.WriteLine("You're expected to get an C+ in ISM 4300");
                else
                    if (inputgrade <= 76 && inputgrade >= 73)
                    Console.WriteLine("You're expected to get an C in ISM 4300");
                else
                    if (inputgrade <= 72 && inputgrade >= 70)
                    Console.WriteLine("You're expected to get an C- in ISM 4300");
                else
                    if (inputgrade <= 69 && inputgrade >= 67)
                    Console.WriteLine("You're expected to get an D+ in ISM 4300");
                else
                    if (inputgrade <= 66 && inputgrade >= 63)
                    Console.WriteLine("You're expected to get an D in ISM 4300");
                else
                    if (inputgrade <= 62 && inputgrade >= 60)
                    Console.WriteLine("You're expected to get an D- in ISM 4300");
                else
                    if (inputgrade <= 59 && inputgrade >= 0)
                    Console.WriteLine("You're expected to get an F in ISM 4300");
            }
            // For any errors with student input
            catch
            {
                Console.WriteLine("Please enter a grade between 0 - 100");
                Console.WriteLine("Please exit the program and try again");
            }


        }
    }
}
