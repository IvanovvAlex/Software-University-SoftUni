using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            int min = arr[0];
            int max = arr[1];

            List<int> list = new List<int>();

            for (int i = min; i <= max; i++)
            {
                list.Add(i);
            }

            string evenOrOdd = Console.ReadLine();

            Func<int, bool> func = Filter(evenOrOdd);

            list = list
                .Where(func)
                .ToList();
            Console.WriteLine(string.Join(" ", list));
        }

        private static Func<int, bool> Filter(string evenOrOdd)
        {
            switch (evenOrOdd)
            {
                case "even":
                    return x => x % 2 == 0;
                case "odd":
                    return x => x % 2 != 0;
                default:
                    return x => true;                   
            }
        }
    }
}
