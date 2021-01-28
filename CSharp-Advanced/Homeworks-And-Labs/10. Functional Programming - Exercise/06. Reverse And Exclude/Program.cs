using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            int n = int.Parse(Console.ReadLine());

            Func<int[], int[]> rev = Reverser;
            arr = rev(arr);
            
            arr = arr
                .Where(x => x % n != 0)
                .ToArray();
            Console.WriteLine(string.Join(" ", arr));
        }

       

        private static int[] Reverser(int[] array)
        {
            int holder = 0;
            int size = array.Length;
            for (int i = 0; i < size / 2; ++i)
            {
                holder = array[i];
                array[i] = array[size - 1 - i];
                array[size - 1 - i] = holder;
            }
            return array;
        }
    }
}
