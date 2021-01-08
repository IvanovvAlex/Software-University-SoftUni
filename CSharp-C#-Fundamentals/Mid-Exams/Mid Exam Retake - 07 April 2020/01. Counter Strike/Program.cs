using System;
using System.Linq;

namespace _01._Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            int wins = 0;

            while (firstCommand[0] != "End")
            {
                string[] command = firstCommand;

                if (int.Parse(command[0]) > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    return;
                }

                energy -= int.Parse(command[0]);
                wins++;

                if (wins % 3 == 0 && wins != 0)
                {
                    energy += wins;
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine($"Won battles: {wins}. Energy left: {energy}");
        }
    }
}
