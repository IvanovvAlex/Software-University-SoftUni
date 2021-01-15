using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            StringBuilder text = new StringBuilder(); 

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int act = int.Parse(command[0]);

                switch (act)
                {
                    case 1:
                        stack.Push(text.ToString());
                        text.Append(command[1]);                        
                        break;
                    case 2:
                        stack.Push(text.ToString());
                        int count = int.Parse(command[1]);

                        text.Remove(text.Length - count, count);

                        break;
                    case 3:
                        
                        int index = int.Parse(command[1]) - 1;
                        if (index >= 0 && index < text.Length)
                        {
                            Console.WriteLine(text[index]);
                        }                                                                                                
                        break;
                    case 4:
                        text.Clear();
                        text.Append(stack.Pop());
                        break;
                }
            }
        }
    }
}
