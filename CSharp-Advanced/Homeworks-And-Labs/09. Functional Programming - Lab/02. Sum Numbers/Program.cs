using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)                
                .ToArray();
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr.Sum());
        }
    }
}
