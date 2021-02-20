using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int> (Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> queue = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            int storage = 0;
        }
    }
}
