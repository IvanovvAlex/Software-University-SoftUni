using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstLength = n[0];
            int secondLength = n[1];

            HashSet<int> firstSet = new HashSet<int>();

            for (int i = 0; i < firstLength; i++)
            {
                int add = int.Parse(Console.ReadLine());
                firstSet.Add(add);
            }

            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < secondLength; i++)
            {
                int add = int.Parse(Console.ReadLine());
                secondSet.Add(add);
            }

            HashSet<int> resultSet = new HashSet<int>();

            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    resultSet.Add(item);
                }
            }

            Console.WriteLine(string.Join(' ', resultSet));
        }
    }
}
