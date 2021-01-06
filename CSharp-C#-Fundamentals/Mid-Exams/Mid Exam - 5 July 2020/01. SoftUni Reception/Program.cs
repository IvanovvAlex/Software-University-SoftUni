using System;
using System.Threading;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmploye = int.Parse(Console.ReadLine());
            int secondEmploye = int.Parse(Console.ReadLine());
            int thirdEmploye = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int peoplePerHour = firstEmploye + secondEmploye + thirdEmploye;
            int hours = 0;
            while (people > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                people -= peoplePerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
