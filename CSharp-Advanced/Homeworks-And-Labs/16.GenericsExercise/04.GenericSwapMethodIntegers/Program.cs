using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var box = new Box<int>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                box.Add(input);
            }

            var swapCommand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = swapCommand[0];
            int secondIndex = swapCommand[1];

            box.Swap(firstIndex, secondIndex);

            Console.WriteLine(box);
        }
    }
}
