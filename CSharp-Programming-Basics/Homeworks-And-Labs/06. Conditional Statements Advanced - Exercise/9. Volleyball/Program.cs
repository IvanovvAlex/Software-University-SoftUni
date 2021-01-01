using System;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            double holidaysInYear = double.Parse(Console.ReadLine());
            double travellingToHisBornCity = double.Parse(Console.ReadLine());

            double sofiaPlays = (48 - travellingToHisBornCity) * 0.75;
            double hisCityPlays = travellingToHisBornCity;
            double holidayPlays = holidaysInYear * 2d / 3;

            double totalPlays = sofiaPlays + hisCityPlays + holidayPlays;

            switch (yearType)
            {
                case "leap":
                    totalPlays += +(totalPlays * 0.15);
                    break;

                case "normal":
                    totalPlays = totalPlays;
                    break;
            }
            Console.WriteLine(Math.Floor(totalPlays));
        }
    }
}
