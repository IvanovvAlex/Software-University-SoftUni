using System;

namespace _01._Next_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            double experience = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            double experienceHave = 0d;


            for (int i = 1; i <= battles; i++)
            {
                double experienceGet = double.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    experienceGet *= 1.15;
                }
                if (i % 5 == 0)
                {
                    experienceGet *= 0.9;
                }
                if (i % 15 == 0)
                {
                    experienceGet *= 1.05;
                }
                experienceHave += experienceGet;
                if (experienceHave >= experience)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    return;
                }
            }
            Console.WriteLine($"Player was not able to collect the needed experience, {experience - experienceHave:f2} more needed.");
        }
    }
}
