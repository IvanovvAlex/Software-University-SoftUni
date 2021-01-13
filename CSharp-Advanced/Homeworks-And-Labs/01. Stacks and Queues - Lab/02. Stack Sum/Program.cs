using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            Stack<int> stack = new Stack<int>(
                input   
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            string[] command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        stack.Push(int.Parse(command[1]));
                        stack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        if (int.Parse(command[1]) <= stack.Count)
                        {
                            for (int i = 0; i < int.Parse(command[1]); i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;
                }
                command = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
