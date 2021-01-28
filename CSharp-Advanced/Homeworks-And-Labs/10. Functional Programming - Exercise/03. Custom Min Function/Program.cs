using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int[], int> func = Min;
            Console.WriteLine(func(arr));
        }

        static int Min(int[] arr)
        {
            int min = int.MaxValue;
            foreach (var item in arr)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
