using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Moving_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            while (firstCommand[0] != "End")
            {
                string[] command = firstCommand;

                switch (command[0])
                {
                    case "Shoot":
                        int index = int.Parse(command[1]);
                        int power = int.Parse(command[2]);

                        if (index >= 0 && index < targets.Count)
                        {
                            if (targets[index] - power > 0)
                            {
                                targets[index] -= power;
                            }
                            else
                            {
                                targets.RemoveAt(index);
                            }
                        }                        

                        break;
                    case "Add":
                        int indexToAdd = int.Parse(command[1]);
                        int value = int.Parse(command[2]);

                        if (indexToAdd >=0 && indexToAdd < targets.Count)
                        {
                            targets.Insert(indexToAdd, value);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;
                    case "Strike":
                        int indexToRemove = int.Parse(command[1]);
                        int radius = int.Parse(command[2]);

                        if (indexToRemove + radius < targets.Count && indexToRemove - radius >= 0)
                        {
                            for (int i = 0; i <= radius; i++)
                            {
                                targets.RemoveAt(indexToRemove);                                
                            }
                            for (int i = 0; i < radius; i++)
                            {
                                targets.RemoveAt(indexToRemove - radius);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine(string.Join("|", targets));
        }
    }
}
