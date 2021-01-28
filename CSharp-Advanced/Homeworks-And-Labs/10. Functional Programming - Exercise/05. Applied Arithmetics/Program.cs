using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command != "print")
                {
                    Func<int, int> func = Filter(command);
                    arr = arr
                        .Select(func)
                        .ToArray();
                }
                else
                {
                    Console.WriteLine(string.Join(" ", arr));
                }
                
                command = Console.ReadLine();
            }            
        }

        static Func<int, int> Filter(string command)
        {
            switch (command)
            {
                case "add":
                    return x => x + 1;                    
                case "multiply":
                    return x => x * 2;
                case "subtract":
                    return x => x - 1;                
                default:
                    return x => x;
            }
        }
    }
}
