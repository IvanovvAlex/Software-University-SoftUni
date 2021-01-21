using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int j = 0; j < line.Length; j++)
                {
                    if (!list.Contains(line[j]))
                    {
                        list.Add(line[j]);
                    }
                }
            }

            foreach (var item in list.OrderBy(n => n))
            {
                Console.Write($"{item} ");
            }
        }
    }
}
