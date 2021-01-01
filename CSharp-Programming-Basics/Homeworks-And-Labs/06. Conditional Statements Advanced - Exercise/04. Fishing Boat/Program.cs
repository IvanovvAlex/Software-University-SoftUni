using System;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyhave = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            double peoples = double.Parse(Console.ReadLine());


            double boatprice = 0;


            switch (season)
            {
                case "spring":
                    boatprice = 3000d;
                    if (peoples <= 6)
                    {
                        boatprice += -(boatprice * 0.10);
                    }
                    if (peoples >= 7 && peoples <= 11)
                    {
                        boatprice += -(boatprice * 0.15);
                    }
                    if (peoples >= 12)
                    {
                        boatprice += -(boatprice * 0.25);
                    }
                    else if (peoples % 2 == 0)
                    {
                        boatprice += -(boatprice * 0.05);
                    }
                    break;

                case "summer":
                    boatprice = 4200d;
                    if (peoples <= 6)
                    {
                        boatprice += -(boatprice * 0.10);
                    }
                    if (peoples >= 7 && peoples <= 11)
                    {
                        boatprice += -(boatprice * 0.15);
                    }
                    if (peoples >= 12)
                    {
                        boatprice += -(boatprice * 0.25);
                    }
                    else if (peoples % 2 == 0)
                    {
                        boatprice += -(boatprice * 0.05);
                    }
                    break;

                case "autumn":
                    boatprice = 4200d;
                    if (peoples <= 6)
                    {
                        boatprice += -(boatprice * 0.10);
                    }
                    if (peoples >= 7 && peoples <= 11)
                    {
                        boatprice += -(boatprice * 0.15);
                    }
                    if (peoples >= 12)
                    {
                        boatprice += -(boatprice * 0.25);
                    }
                    break;

                case "winter":
                    boatprice = 2600d;
                    if (peoples <= 6)
                    {
                        boatprice += -(boatprice * 0.10);
                    }
                    if (peoples >= 7 && peoples <= 11)
                    {
                        boatprice += -(boatprice * 0.15);
                    }
                    if (peoples >= 12)
                    {
                        boatprice += -(boatprice * 0.25);
                    }
                    else if (peoples % 2 == 0)
                    {
                        boatprice += -(boatprice * 0.05);
                    }
                    break;
            }
            if (boatprice <= moneyhave)
            {
                Console.WriteLine($"Yes! You have {moneyhave - boatprice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatprice - moneyhave:f2} leva.");
            }
        }
    }
}
