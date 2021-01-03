using System;

namespace _3._Vacation
{
    class Program
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0d;
            
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16d;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            price = 15d;
                            break;
                        case "Saturday":
                            price = 20d;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    break;
            }
            double total = price * people;

            if (type == "Students" && people >= 30)
            {
                total = total * 0.85;
            }
            if (type == "Business" && people >= 100)
            {
                total = (people - 10) *price;
            }
            if (type == "Regular" && people >= 10 && people <= 20)
            {
                total = total * 0.95;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
