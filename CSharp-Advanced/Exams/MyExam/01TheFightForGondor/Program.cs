using System;
using System.Collections.Generic;
using System.Linq;

namespace _01TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<int> platesList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            Stack<int> orcsStack = new Stack<int>();

            for (int i = 1; i <= n; i++)
            {
                List<int> orcList = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                AddWarriors(orcsStack, orcList);

                if (i % 3 == 0)
                {
                    int additionalWall = int.Parse(Console.ReadLine());
                    platesList.Add(additionalWall);
                }

                while (orcsStack.Count > 0 && platesList.Count > 0)
                {
                    int currentOrc = orcsStack.Pop();
                    int currentPlate = platesList[0];

                    if (currentOrc > currentPlate)
                    {
                        currentOrc -= currentPlate;
                        orcsStack.Push(currentOrc);
                        platesList.RemoveAt(0);
                    }
                    else if (currentOrc < currentPlate)
                    {
                        currentPlate -= currentOrc;
                        platesList[0] = currentPlate;
                    }
                    else
                    {
                        platesList.RemoveAt(0);
                    }
                }

                if (platesList.Count == 0)
                {
                    break;
                }
            }

            PrintOutput(platesList, orcsStack);
        }

        private static void PrintOutput(List<int> plateList, Stack<int> orcsStack)
        {
            if (plateList.Count == 0)
            {

                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {String.Join(", ", orcsStack)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {String.Join(", ", plateList)}");

            }
        }

        private static void AddWarriors(Stack<int> orcStack, List<int> orcsList)
        {
            foreach (var war in orcsList)
            {
                orcStack.Push(war);
            }
        }
    }
}