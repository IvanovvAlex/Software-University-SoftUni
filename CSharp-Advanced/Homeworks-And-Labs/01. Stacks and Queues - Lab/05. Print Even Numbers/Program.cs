using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<int> startQueue = new Queue<int>(
                input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());
            Queue<int> resultQueue = new Queue<int>();

            while (startQueue.Count != 0)
            {          
                int num = startQueue.Peek();
                if (num % 2 == 0)
                {
                    resultQueue.Enqueue(startQueue.Dequeue());
                }
                else
                {
                    startQueue.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", resultQueue));
        }
    }
}
