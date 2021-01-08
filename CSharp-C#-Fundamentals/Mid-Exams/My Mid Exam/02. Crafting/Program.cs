using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weapon = Console.ReadLine()
                .Split("|")
                .ToArray();

            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            List<string> odd = new List<string>();
            List<string> even = new List<string>();

            while (firstCommand[0] != "Done")
            {
                string[] command = firstCommand;

                switch (command[0])
                {
                    case "Move":
                        switch (command[1])
                        {

                            case "Left":
                                if (int.Parse(command[2]) - 1 >= 0 && int.Parse(command[2]) - 1 < weapon.Length)
                                {
                                    string leftItem = weapon[int.Parse(command[2]) - 1];
                                    string item = weapon[int.Parse(command[2])];
                                    weapon[int.Parse(command[2])] = leftItem;
                                    weapon[int.Parse(command[2]) - 1] = item;
                                    //weapon.Insert(int.Parse(command[2]), weapon[int.Parse(command[2])-1]);
                                    //weapon.RemoveAt(int.Parse(command[2])-2);
                                }
                                break;
                            case "Right":
                                if (int.Parse(command[2]) + 1 >= 0 && int.Parse(command[2]) + 1 < weapon.Length)
                                {
                                    string rightItem = weapon[int.Parse(command[2]) + 1];
                                    string item = weapon[int.Parse(command[2])];
                                    weapon[int.Parse(command[2])] = rightItem;
                                    weapon[int.Parse(command[2]) + 1] = item;
                                    //weapon.Insert(int.Parse(command[2]), weapon[int.Parse(command[2])+1]);
                                    //weapon.RemoveAt(int.Parse(command[2])+2);
                                }
                                break;
                        }
                        break;

                    case "Check":
                        switch (command[1])
                        {
                            case "Even":

                                for (int i = 0; i < weapon.Length; i++)
                                {
                                    if (i % 2 == 0)
                                    {
                                        even.Add(weapon[i]);
                                    }
                                }
                                Console.WriteLine(string.Join(" ", even));
                                for (int i = 0; i < even.Count; i++)
                                {
                                    even.RemoveAt(i);
                                    i--;
                                }
                                break;
                            case "Odd":

                                for (int i = 0; i < weapon.Length; i++)
                                {
                                    if (i % 2 != 0)
                                    {
                                        odd.Add(weapon[i]);
                                    }                                    
                                }
                                Console.WriteLine(string.Join(" ", odd));
                                for (int i = 0; i < odd.Count; i++)
                                {
                                    odd.RemoveAt(i);
                                    i--;
                                }
                                break;
                        }
                        break;
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
            Console.WriteLine($"You crafted {string.Join("", weapon)}!");            
        }
    }
}
