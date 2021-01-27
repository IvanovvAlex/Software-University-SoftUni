using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> prices = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .Select(x => x += (x * 0.2m))
                .ToList();

            prices.ForEach(x => Console.WriteLine($"{x:f2}"));
        }
    }
}
