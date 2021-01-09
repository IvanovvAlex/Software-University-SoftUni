using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(n => n.Length % 2 == 0)
                .ToArray();

            foreach (var word in line)
            {
                Console.WriteLine(word);
            }
        }
    }
}
