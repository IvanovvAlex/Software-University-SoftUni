using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int pushNum = int.Parse(firstLine[0]);
            int popNum = int.Parse(firstLine[1]);
            int searchFor = int.Parse(firstLine[2]);

            string[] secondLine = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < secondLine.Length; i++)
            {
                queue.Enqueue(int.Parse(secondLine[i]));
            }
            for (int i = 0; i < popNum; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (queue.Contains(searchFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}
