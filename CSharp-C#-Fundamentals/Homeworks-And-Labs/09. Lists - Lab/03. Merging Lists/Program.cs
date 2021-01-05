using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List<int> result = new List<int>(firstList.Count + secondList.Count);

            int firstRepeats = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < firstRepeats; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            int secondRepeats = Math.Max(firstList.Count, secondList.Count);

            for (int i = firstRepeats; i < secondRepeats; i++)
            {
                if (firstList.Count > secondList.Count)
                {
                    result.Add(firstList[i]);
                }
                else
                {
                    result.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
