using System;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();

            double moneyNeed = 0;

            switch (room)
            {
                case "room for one person":
                    moneyNeed = (days - 1) * 18.0;
                    break;

                case "apartment":
                    moneyNeed = (days - 1) * 25.0;
                    if (days < 10)
                    {
                        moneyNeed += -(moneyNeed * 0.30);
                    }
                    if (days >= 10 && days <= 15)
                    {
                        moneyNeed += -(moneyNeed * 0.35);
                    }
                    if (days > 15)
                    {
                        moneyNeed += -(moneyNeed * 0.50);
                    }
                    break;

                case "president apartment":
                    moneyNeed = (days - 1) * 35.0;
                    if (days < 10)
                    {
                        moneyNeed += -(moneyNeed * 0.10);
                    }
                    if (days >= 10 && days <= 15)
                    {
                        moneyNeed += -(moneyNeed * 0.15);
                    }
                    if (days > 15)
                    {
                        moneyNeed += -(moneyNeed * 0.20);
                    }
                    break;
            }
            switch (rate)
            {
                case "positive":
                    moneyNeed += +(moneyNeed * 0.25);
                    break;
                case "negative":
                    moneyNeed += -(moneyNeed * 0.10);
                    break;
            }

            Console.WriteLine($"{moneyNeed:f2}");
        }
    }
}
