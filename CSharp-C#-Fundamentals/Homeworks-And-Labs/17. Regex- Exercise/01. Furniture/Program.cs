using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>\w+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";
            string firstCommand = Console.ReadLine();

            StringBuilder allProducts = new StringBuilder();

            while (firstCommand != "Purchase")
            {
                string command = firstCommand;

                allProducts.Append(command + ' ');

                firstCommand = Console.ReadLine();
            }
           
            MatchCollection buyedProducts = Regex.Matches(allProducts.ToString(), pattern);

            Console.WriteLine("Bought furniture:");

            decimal totalPrice = 0m;

            foreach (Match item in buyedProducts)
            {
                Console.WriteLine($"{item.Groups["name"].Value}");

                totalPrice += (decimal.Parse(item.Groups["price"].Value)
                    * int.Parse(item.Groups["quant"].Value));
            }
            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
