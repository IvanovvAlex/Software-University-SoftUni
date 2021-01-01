using System;

namespace Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgStrawberry = double.Parse(Console.ReadLine());
            double numBananas = double.Parse(Console.ReadLine());
            double numOranges = double.Parse(Console.ReadLine());
            double numRaspberries = double.Parse(Console.ReadLine());
            double numStrawberry = double.Parse(Console.ReadLine());

            double priceStrawberry = priceKgStrawberry;
            double priceRaspberries = priceKgStrawberry / 2.0;
            double priceOranges = priceRaspberries - (priceRaspberries * 0.40);
            double priceBananas = priceRaspberries - (priceRaspberries * 0.80);

            double totalPriceStrawberry = priceStrawberry * numStrawberry;
            double totalPriceRaspberries = priceRaspberries * numRaspberries;
            double totalPriceOranges = priceOranges * numOranges;
            double totalPriceBananas = priceBananas * numBananas;

            double total = totalPriceBananas + totalPriceOranges + totalPriceRaspberries + totalPriceStrawberry;
            Console.WriteLine($"{total:f2}");
        }
    }
}
