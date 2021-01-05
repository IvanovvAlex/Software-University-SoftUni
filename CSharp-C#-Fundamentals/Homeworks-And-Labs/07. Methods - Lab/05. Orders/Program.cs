using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal singlePrice = FindSinglePeice(product);
            PrintTotal(quantity, singlePrice);
        }

        private static void PrintTotal(int quantity, decimal singlePrice)
        {
            Console.WriteLine($"{quantity * singlePrice:f2}");
        }

        static decimal FindSinglePeice(string product)
        {
            decimal singlePrice = 0m;
            switch (product)
            {
                case "coffee":
                    singlePrice = 1.5m;
                    break;
                case "water":
                    singlePrice = 1m;
                    break;
                case "coke":
                    singlePrice = 1.4m;
                    break;
                case "snacks":
                    singlePrice = 2m;
                    break;
            }
            return singlePrice;
        }
    }
}
