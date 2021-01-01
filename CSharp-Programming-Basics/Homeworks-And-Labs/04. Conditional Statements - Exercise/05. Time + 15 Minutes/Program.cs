using System;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes;
            int theHours = (15 + totalMinutes) / 60;
            int theMinutes = (15 + totalMinutes) % 60;
            if (theHours > 23)
            {
                theHours = 0;
            }

            if (theMinutes < 10)
            {
                Console.WriteLine($"{theHours}:0{theMinutes}");
            }
            else
            {
                Console.WriteLine($"{theHours}:{theMinutes}");
            }
        }
    }
}
