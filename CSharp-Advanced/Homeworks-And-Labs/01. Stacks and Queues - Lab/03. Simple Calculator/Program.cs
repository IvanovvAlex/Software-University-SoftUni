using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);             

            Stack<string> stack = new Stack<string>(new Stack<string>(input));            

           
            while (stack.Count > 1)
            {
                int leftNum = int.Parse(stack.Pop());
                string sign = stack.Pop();   
                int rightNum = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((leftNum + rightNum).ToString());
                        break;
                    case "-":
                        stack.Push((leftNum - rightNum).ToString());
                        break;
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
