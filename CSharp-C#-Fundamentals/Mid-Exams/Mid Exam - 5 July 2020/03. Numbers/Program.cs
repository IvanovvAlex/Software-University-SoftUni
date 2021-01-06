using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            double avarage = 0d;

            for (int i = 0; i < list.Count; i++)
            {
                avarage += list[i];
            }
            avarage /= list.Count;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= avarage)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }
            list.Sort();
            list.Reverse();

            if (list.Count > 5)
            {
                for (int i = 5; i < list.Count; i++)
                {
                    list.RemoveAt(i);
                    i--;
                }
            }

            if (list.Count >= 1)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            else
            {
                Console.Write("No");
            }
            
        }
    }
}
