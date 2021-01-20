using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> info = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (!info.ContainsKey(input[0]))
                {
                    info.Add(input[0], new List<decimal>());
                }

                info[input[0]].Add(decimal.Parse(input[1]));
            }

            foreach (var people in info)
            {
                Console.Write($"{people.Key} -> ");
                foreach (var item in people.Value)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.Write($"(avg: {(people.Value.Sum() / people.Value.Count):f2})");
                Console.WriteLine();
            }
        }
    }
}
