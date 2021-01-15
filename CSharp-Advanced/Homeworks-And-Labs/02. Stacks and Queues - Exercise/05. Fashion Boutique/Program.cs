using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int capacity = int.Parse(Console.ReadLine());
            int totalBoxes = 1;
            int currentBox = 0;

            while (queue.Count > 0)
            {
                int clothes = queue.Dequeue();
                if ((currentBox + clothes) <= capacity)
                {
                    currentBox += clothes;
                }
                else
                {
                    totalBoxes++;
                    currentBox = 0;
                    currentBox += clothes;
                }
            }
            Console.WriteLine(totalBoxes);
        }
    }
}
