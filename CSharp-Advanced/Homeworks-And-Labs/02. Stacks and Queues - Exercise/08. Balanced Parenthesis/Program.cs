using System;
using System.Linq;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> parenthesStack = new Stack<char>();
            foreach (var symbol in input)
            {
                if (parenthesStack.Any())
                {
                    char check = parenthesStack.Peek();
                    if (check == '{' && symbol == '}')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                    else if (check == '[' && symbol == ']')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                    else if (check == '(' && symbol == ')')
                    {
                        parenthesStack.Pop();
                        continue;
                    }
                }
                parenthesStack.Push(symbol);
            }
            Console.WriteLine(!parenthesStack.Any() ? "YES" : "NO");
        }
    }
}
