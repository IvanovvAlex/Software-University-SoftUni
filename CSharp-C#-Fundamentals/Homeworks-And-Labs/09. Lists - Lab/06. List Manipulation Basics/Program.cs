using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] firstCommand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            while (firstCommand[0].ToLower() != "end")
            {
                switch (firstCommand[0].ToLower())
                {
                    case "add":
                        list.Add(int.Parse(firstCommand[1]));
                        break;
                    case "remove":
                        list.Remove(int.Parse(firstCommand[1]));
                        break;
                    case "removeat":
                        list.RemoveAt(int.Parse(firstCommand[1]));
                        break;
                    case "insert":
                        list.Insert(int.Parse(firstCommand[2]), int.Parse(firstCommand[1]));
                        break;
                }
                firstCommand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(string.Join(' ', list));
        }
    }
}
