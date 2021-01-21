using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            SortedDictionary<char, int> info = new SortedDictionary<char, int>();

            for (int i = 0; i < line.Length; i++)
            {
                
                if (!info.ContainsKey(line[i]))
                {
                    info.Add(line[i], 0);
                }
                info[line[i]]++;
            }

            foreach (var item in info)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
