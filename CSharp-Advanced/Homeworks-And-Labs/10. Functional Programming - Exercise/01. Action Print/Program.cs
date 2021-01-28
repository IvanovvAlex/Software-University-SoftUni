using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> action = Reader;
            action(Console.ReadLine());                      
        }

        static void Reader(string input)
        {
            string[] arr = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
