using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] collection = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, double> result = new Dictionary<double, double>();

            foreach (var item in collection)
            {
                if (!result.ContainsKey(item))
                {
                    result.Add(item, 0);
                }
                result[item]++;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
