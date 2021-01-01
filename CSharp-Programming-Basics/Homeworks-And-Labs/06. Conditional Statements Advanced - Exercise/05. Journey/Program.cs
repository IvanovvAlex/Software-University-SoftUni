using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string typeHoliday = "a";
            string destination = "b";
            double moneyNeed = 0;

            switch (season)
            {
                case "summer":
                    typeHoliday = "Camp";

                    if (moneyHave <= 100)
                    {
                        moneyNeed = moneyHave - (moneyHave * 0.70);
                        destination = "Bulgaria";
                    }
                    if (moneyHave <= 1000 && moneyHave > 100)
                    {
                        moneyNeed = moneyHave - (moneyHave * 0.60);
                        destination = "Balkans";
                    }
                    if (moneyHave > 1000)
                    {
                        moneyNeed = moneyHave - (moneyHave * 0.10);
                        destination = "Europe";
                        typeHoliday = "Hotel";
                    }

                    break;


                case "winter":
                    typeHoliday = "Hotel";

                    if (moneyHave <= 100)
                    {
                        moneyNeed = moneyHave - (moneyHave * 0.30);
                        destination = "Bulgaria";
                    }
                    if (moneyHave <= 1000 && moneyHave > 100)
                    {
                        moneyNeed = moneyHave - (moneyHave * 0.20);
                        destination = "Balkans";
                    }
                    if (moneyHave > 1000)
                    {
                        moneyNeed = moneyHave - (moneyHave * 0.10);
                        destination = "Europe";
                    }

                    break;
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{typeHoliday} - {moneyNeed:f2}");
        }
    }
}
