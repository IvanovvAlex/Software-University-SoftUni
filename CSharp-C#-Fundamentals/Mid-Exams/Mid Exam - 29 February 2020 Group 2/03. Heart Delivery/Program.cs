using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Heart_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> naighborhood = Console.ReadLine()
                .Split('@')
                .Select(int.Parse)
                .ToList();

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            int lastPosition = 0;
            int currentPosition = 0;
            while (firstCommand[0] != "Love!")
            {
                string[] command = firstCommand;
                
                int jump = int.Parse(command[1]);

                if (currentPosition + jump < naighborhood.Count)
                {
                    currentPosition += jump;
                    if (naighborhood[currentPosition] != 0)
                    {
                        naighborhood[currentPosition] -= 2;
                        if (naighborhood[currentPosition] == 0)
                        {
                            Console.WriteLine($"Place {currentPosition} has Valentine's day.");
                        }                       
                    }
                    else
                    {
                        Console.WriteLine($"Place {currentPosition} already had Valentine's day.");                       
                    }
                    
                }
                else
                {
                    currentPosition = 0;
                    if (naighborhood[currentPosition] != 0)
                    {
                        naighborhood[currentPosition] -= 2;
                        if (naighborhood[currentPosition] == 0)
                        {
                            Console.WriteLine($"Place {currentPosition} has Valentine's day.");                           
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Place {currentPosition} already had Valentine's day.");                        
                    }
                }

                lastPosition = currentPosition;

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            int fails = 0;

            for (int i = 0; i < naighborhood.Count; i++)
            {
                if (naighborhood[i] != 0)
                {
                    fails++;
                }
            }
            if (fails > 0)
            {
                Console.WriteLine($"Cupid has failed {fails} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }
    }
}
