using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<char, int> result = new Dictionary<char, int>();

            foreach (var word in line)
            {
                foreach (var symbol in word)
                {
                    if (result.ContainsKey(symbol))
                    {
                        result[symbol]++;
                    }
                    else
                    {
                        result.Add(symbol, 1);
                    }
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
