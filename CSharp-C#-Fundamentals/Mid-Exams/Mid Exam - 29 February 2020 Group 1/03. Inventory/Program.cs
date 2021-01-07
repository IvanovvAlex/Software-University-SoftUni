using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace _03._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split(", ")
                .ToList();

            string[] firstCommand = Console.ReadLine()
                .Split(" - ")
                .ToArray();

            while (true)
            {
                string[] secondCommand = firstCommand;
                switch (secondCommand[0])
                {
                    case "Collect":
                        bool exist = false;
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == secondCommand[1])
                            {
                                exist = true;
                            }
                        }
                        if (exist == false)
                        {
                            list.Add(secondCommand[1]);
                        }
                        break;
                    case "Drop":
                        list.Remove(secondCommand[1]);
                        break;

                    case "Combine Items":
                        string[] item = secondCommand[1]
                            .Split(':')
                            .ToArray();
                        string oldItem = item[0];
                        string newItem = item[1];

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == oldItem)
                            {
                                list.Insert(i + 1, newItem);
                            }
                        }
                        break;

                    case "Renew":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == secondCommand[1])
                            {
                                list.RemoveAt(i);
                                list.Add(secondCommand[1]);
                            }
                        }
                        break;

                    case "Craft!":
                        Console.WriteLine(string.Join(", ", list));
                        return;
                }
                firstCommand = Console.ReadLine()
                .Split(" - ")
                .ToArray();
            }
        }
    }
}
