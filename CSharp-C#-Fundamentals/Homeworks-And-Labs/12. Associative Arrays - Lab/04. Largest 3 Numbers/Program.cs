using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line = Console.ReadLine()
                .Split()
                .Select(int.Parse)                
                .ToArray();
            int[] ordered = line
                .OrderByDescending(n => n)
                .ToArray();

            for (int i = 0; i <= 2; i++)
            {
                try
                {
                    Console.Write($"{ordered[i]} ");
                }
                catch (Exception)
                {

                    
                }
            }
        }
    }
}
