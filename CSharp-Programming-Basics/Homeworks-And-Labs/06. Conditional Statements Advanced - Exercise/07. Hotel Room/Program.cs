using System;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine().ToLower();
            double nights = double.Parse(Console.ReadLine());

            double moneyApartament = 0;
            double moneyStudio = 0;
            if (mount == "may" || mount == "october")
            {
                moneyApartament = nights * 65d;
                moneyStudio = nights * 50d;

                if (nights > 7d && nights <= 14d)
                {

                    moneyStudio += -(moneyStudio * 0.05);
                }
                if (nights > 14d)
                {
                    moneyStudio += -(moneyStudio * 0.30);
                }
                if (nights > 14d)
                {
                    moneyApartament += -(moneyApartament * 0.10);
                }
            }
            if (mount == "june" || mount == "september")
            {
                moneyApartament = nights * 68.70;
                moneyStudio = nights * 75.20;

                if (nights > 14d)
                {
                    moneyStudio += -(moneyStudio * 0.20);
                }
                if (nights > 14d)
                {
                    moneyApartament += -(moneyApartament * 0.10);
                }
            }
            if (mount == "july" || mount == "august")
            {
                moneyApartament = nights * 77d;
                moneyStudio = nights * 76d;

                if (nights > 14d)
                {
                    moneyApartament += -(moneyApartament * 0.10);
                }
            }
            Console.WriteLine($"Apartment: {moneyApartament:f2} lv.");
            Console.WriteLine($"Studio: {moneyStudio:f2} lv.");
        }
    }
}
