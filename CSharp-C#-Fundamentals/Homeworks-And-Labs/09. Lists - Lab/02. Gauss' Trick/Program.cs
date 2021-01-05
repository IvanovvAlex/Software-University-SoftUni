using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int repeats = line.Count / 2;

            for (int i = 0; i < repeats; i++)
            {
                line[i] += line[line.Count - 1];
                line.RemoveAt(line.Count - 1);
                
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}
