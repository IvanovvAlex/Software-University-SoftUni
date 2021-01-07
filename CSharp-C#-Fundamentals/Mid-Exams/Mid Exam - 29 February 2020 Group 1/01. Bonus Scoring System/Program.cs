using System;
using System.Collections.Generic;

namespace _01._Bonus_Scoring_System
{
    class Program
    {
        static void Main(string[] args)
        {
            double countStudents = double.Parse(Console.ReadLine());
            double countLectures = double.Parse(Console.ReadLine());
            double initialBonus = double.Parse(Console.ReadLine());

            double biggerNum = 0d;
            double maxBonus = 0d;

            for (int i = 0; i < countStudents; i++)
            {
                double num = double.Parse(Console.ReadLine());
                double bonus = Math.Ceiling((num / countLectures) * (5d + initialBonus));

                if (num > biggerNum)
                {
                    biggerNum = num;
                    maxBonus = bonus;
                }
            }

            Console.WriteLine($"Max Bonus: {maxBonus:f0}.");
            Console.WriteLine($"The student has attended {biggerNum:f0} lectures.");
        }
    }
}
