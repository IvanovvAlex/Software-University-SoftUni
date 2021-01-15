using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Stack_Operations
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

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < secondLine.Length; i++)
            {
                stack.Push(int.Parse(secondLine[i]));
            }
            for (int i = 0; i < popNum; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
                return;
            }
            else if (stack.Contains(searchFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
