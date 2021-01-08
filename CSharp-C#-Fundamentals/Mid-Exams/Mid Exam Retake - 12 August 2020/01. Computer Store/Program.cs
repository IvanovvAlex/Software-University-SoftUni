using System;
using System.Linq;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            decimal totalWithoutTaxes = 0m;

            while (firstCommand[0] != "regular" && firstCommand[0] != "special")
            {
                string[] command = firstCommand;

                decimal price = decimal.Parse(command[0]);

                if (price > 0)
                {
                    totalWithoutTaxes += price;
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            decimal total = totalWithoutTaxes * 1.2m;
            decimal taxes = total - totalWithoutTaxes;

            if (firstCommand[0] == "special")
            {
                total = total * 0.90m;                
            }
            if (total > 0)
            {
                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {total:f2}$");
            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
        }
    }
}
