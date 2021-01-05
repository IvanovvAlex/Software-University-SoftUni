using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> line = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < line.Count; i++)
            {
                if (line[i] < 0)
                {
                    line.Remove(line[i--]);      
                }
            }
            line.Reverse();
            if (line.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ", line));
            }
        }
    }
}
