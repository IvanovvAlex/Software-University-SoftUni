using System;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            int shoots = 0;

            while (firstCommand[0] != "End")
            {
                string[] command = firstCommand;
                int index = int.Parse(command[0]);
                int num = 0;
                bool shootOrNot = false;

                if (index >= 0 && index < targets.Length && targets[index] != -1)
                {
                    num = targets[index];
                    targets[index] = -1;
                    shoots++;
                    shootOrNot = true;
                }

                if (shootOrNot)
                {
                    for (int i = 0; i < targets.Length; i++)
                    {
                        if (targets[i] == -1)
                        {
                            continue;
                        }
                        if (targets[i] > num)
                        {
                            targets[i] -= num;
                        }
                        else
                        {
                            targets[i] += num;
                        }
                    }
                }                

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine($"Shot targets: {shoots} -> {string.Join(" ", targets)}");
        }
    }
}
