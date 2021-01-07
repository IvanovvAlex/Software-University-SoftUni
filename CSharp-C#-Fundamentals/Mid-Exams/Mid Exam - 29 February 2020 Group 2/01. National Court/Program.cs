using System;
using System.Runtime.ConstrainedExecution;

namespace _01._National_Court
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPeople = int.Parse(Console.ReadLine());
            int secondPeople = int.Parse(Console.ReadLine());
            int thirdPeople = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            int peoplePerHour = firstPeople + secondPeople + thirdPeople;
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
