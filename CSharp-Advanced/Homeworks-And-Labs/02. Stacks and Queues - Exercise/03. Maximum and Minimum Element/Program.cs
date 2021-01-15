using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int act = int.Parse(line[0]);

                switch (act)
                {
                    case 1:
                        stack.Push(int.Parse(line[1]));
                        break;
                    case 2:
                        if (stack.Count > 0)
                        {
                            stack.Pop();
                        }
                        break;
                    case 3:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }                       
                        break;
                    case 4:
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }                        
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
