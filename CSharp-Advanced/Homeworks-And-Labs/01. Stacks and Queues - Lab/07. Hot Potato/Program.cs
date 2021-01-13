using System;
using System.Collections.Generic;

namespace _07._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            Queue<string> names = new Queue<string>(input);
            int tosses = 0;
            while (names.Count > 1)
            {
                tosses++;
                string name = names.Dequeue();
                if (tosses == n)
                {
                    Console.WriteLine($"Removed {name}");
                    tosses = 0;
                }
                else
                {
                    names.Enqueue(name);
                }
            }

            Console.WriteLine($"Last is {names.Dequeue()}");
        }
    }
}
