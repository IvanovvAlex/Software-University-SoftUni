using System;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            if (product == "coffee")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(quantity * 0.50);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(quantity * 0.40);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(quantity * 0.45);
                }
            }
            else if (product == "water")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(quantity * 0.80);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(quantity * 0.70);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(quantity * 0.70);
                }
            }
            else if (product == "beer")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(quantity * 1.20);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.15);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(quantity * 1.10);
                }
            }
            else if (product == "sweets")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(quantity * 1.45);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.30);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(quantity * 1.35);
                }
            }
            else if (product == "peanuts")
            {
                if (city == "sofia")
                {
                    Console.WriteLine(quantity * 1.60);
                }
                else if (city == "plovdiv")
                {
                    Console.WriteLine(quantity * 1.50);
                }
                else if (city == "varna")
                {
                    Console.WriteLine(quantity * 1.55);
                }
            };
        }
    }
}
