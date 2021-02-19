using System;
using System.Collections.Generic;
using System.Linq;

namespace _01FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            Queue<int> roses = new Queue<int>(Console.ReadLine()
               .Split(", ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray());

            int storage = 0;
            int wreaths = 0;

            while (roses.Count != 0 && lilies.Count != 0)
            {
                int currentLilies = lilies.Pop();
                int currentRoses = roses.Dequeue();
                int sum = currentLilies + currentRoses;
                if (sum == 15)
                {
                    wreaths++;
                }
                else if (sum > 15)
                {
                    while (true)
                    {
                        if (sum > 15)
                        {
                            sum -= 2;
                        }
                        else if (sum == 15)
                        {
                            wreaths++;
                            break;
                        }
                        else
                        {
                            storage += sum;
                            break;
                        }
                    }
                }
                else
                {
                    storage += sum;
                }
            }
            while (storage >= 15)
            {
                wreaths++;
                storage -= 15;
            }
            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5 - wreaths} wreaths more!");
            }
        }
    }
}
