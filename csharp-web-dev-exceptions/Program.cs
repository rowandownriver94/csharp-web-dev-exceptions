using System;
using System.Collections.Generic;

//Exercises for the Exceptions Chapter

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {

        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Value of y must be greater than 0.");
            }

            double score = x / y;

            return score;

        }

        static int CheckFileExtension(string fileName)
        {
            int score = 0;

            string result = fileName.Substring(fileName.Length - 3);

            if (result == ".cs")
            {
                score += 1;

                return score;

            } else if (result == "" || result == null)
            {

                throw new ArgumentNullException("Please submit a file for grading!");

            }

            return score;

        }


        static void Main(string[] args)
        {
            // Test out your Divide() function here!

            try
            {
                Console.WriteLine(Divide(80, 100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");


            foreach (var student in students)
            {
                try
                {
                    string fileName = student.Value;

                    Console.WriteLine($"{student.Key}: {CheckFileExtension(fileName)}");
                    

                }
                catch
                {
                    Console.WriteLine($"{student.Key}: File is not of type .cs. Score is 0.");
                }


            }

        }
    }
}
