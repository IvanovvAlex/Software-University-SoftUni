using System;

namespace Charity_Campaign
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = int.Parse(Console.ReadLine());
            double bakers = int.Parse(Console.ReadLine());

            double cakes = int.Parse(Console.ReadLine());
            double waffles = int.Parse(Console.ReadLine());
            double pancakes = int.Parse(Console.ReadLine());

            double totalCakes = cakes * 45d;
            double totalWaffles = waffles * 5.80;
            double totalPancakes = pancakes * 3.20;

            double total = totalCakes + totalWaffles + totalPancakes;
            total = total - (total / 8);
            total = (total * bakers) * days;
            Console.WriteLine(total);
        }
    }
}
