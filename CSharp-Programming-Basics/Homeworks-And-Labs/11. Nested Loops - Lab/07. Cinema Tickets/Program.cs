using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            int totalStudent = 0;
            int totalStandard = 0;
            int totalKid = 0;
            int totalTiket = 0;
            while (command != "Finish")
            {
                command = Console.ReadLine();
                int student = 0;
                int standard = 0;
                int kid = 0;
                if (command == "Finish")
                {
                    break;
                }
                int freePosition = int.Parse(Console.ReadLine());
                for (int i = 0; i < freePosition; i++)
                {
                    string curentPosition = Console.ReadLine();
                    if (curentPosition == "student")
                    {
                        student++;
                    }
                    else if (curentPosition == "standard")
                    {
                        standard++;
                    }
                    else if (curentPosition == "kid")
                    {
                        kid++;
                    }
                    else if (curentPosition == "End")
                    {
                        break;
                    }
                }
                totalStudent += student;
                totalStandard += standard;
                totalKid += kid;
                Console.WriteLine($"{command} - {((student + standard + kid) / (double)freePosition) * 100:f2}% full.");
            }
            totalTiket = totalStudent + totalStandard + totalKid;
            Console.WriteLine($"Total tickets: {totalTiket}");
            Console.WriteLine($"{(totalStudent / (double)totalTiket) * 100:f2}% student tickets.");
            Console.WriteLine($"{(totalStandard / (double)totalTiket) * 100:f2}% standard tickets.");
            Console.WriteLine($"{(totalKid / (double)totalTiket) * 100:f2}% kids tickets.");
        }
    }
}