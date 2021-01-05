using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            string gradeWithWords = GradeWithWords(grade);
            Console.WriteLine(gradeWithWords);
        }

         static string GradeWithWords(double grade)
        {
            string gradeWithWords = string.Empty;
            if (2d <= grade && grade <= 2.99)
            {
                gradeWithWords = "Fail";
            }
            else if (3d <= grade && grade <= 3.49d)
            {
                gradeWithWords = "Poor";
            }
            else if (3.5d <= grade && grade <= 4.49d)
            {
                gradeWithWords = "Good";
            }
            else if (4.5d <= grade && grade <= 5.49d)
            {
                gradeWithWords = "Very good";
            }
            else if (5.5d <= grade && grade <= 6d)
            {
                gradeWithWords = "Excellent";
            }
            else
            {
                gradeWithWords = "Invalid grade!";
            }
            return gradeWithWords;
        }
    }
}
