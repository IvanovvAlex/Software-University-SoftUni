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

            string text = string.Empty; 

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int act = int.Parse(command[0]);

                switch (act)
                {
                    case 1:
                        stack.Push(text);
                        text += command[1];                        
                        break;
                    case 2:
                        stack.Push(text);
                        int reps = int.Parse(command[1]);
                        for (int j = 0; j < reps; j++)
                        {
                            text = text.Remove(text.Length - 1, 1);                           
                        }
                        
                        break;
                    case 3:
                        
                        int index = int.Parse(command[1]);
                        try
                        {
                            Console.WriteLine(text[index-1]);
                        }
                        catch (Exception)
                        {
                        }
                                              
                        break;
                    case 4:
                        text = stack.Pop();
                        break;
                }
            }
        }
    }
}
