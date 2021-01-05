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

            bool isChanged = false;

            while (firstCommand[0].ToLower() != "end")
            {
                switch (firstCommand[0].ToLower())
                {
                    case "add":
                        list.Add(int.Parse(firstCommand[1]));
                        isChanged = true;
                        break;
                    case "remove":
                        list.Remove(int.Parse(firstCommand[1]));
                        isChanged = true;
                        break;
                    case "removeat":
                        list.RemoveAt(int.Parse(firstCommand[1]));
                        isChanged = true;
                        break;
                    case "insert":
                        list.Insert(int.Parse(firstCommand[2]), int.Parse(firstCommand[1]));
                        isChanged = true;
                        break;
                    case "contains":
                        string result = list.Contains(int.Parse(firstCommand[1])) ? "Yes" : "No such number";
                        Console.WriteLine(result);
                        break;
                    case "printeven":
                        Console.WriteLine(string.Join(" ", list
                            .Where(n => n % 2 == 0)));
                        break;
                    case "printodd":
                        Console.WriteLine(string.Join(" ", list
                            .Where(n => n % 2 != 0)));
                        break;
                    case "getsum":
                        Console.WriteLine(list.Sum());
                        break;
                    case "filter":
                        string print = string.Empty;
                        switch (firstCommand[1])
                        {
                            case "<":
                                print = string.Join(" ", list
                                    .Where(n => n < int.Parse(firstCommand[2])));
                                break;
                            case ">":
                                print = string.Join(" ", list
                                    .Where(n => n > int.Parse(firstCommand[2])));
                                break;
                            case "<=":
                               print = string.Join(" ", list
                                    .Where(n => n <= int.Parse(firstCommand[2])));
                                break;
                            case ">=":
                               print = string.Join(" ", list
                                    .Where(n => n >= int.Parse(firstCommand[2])));                               
                                break;
                        }
                        Console.WriteLine(print);
                        break;
                }
                firstCommand = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            if (isChanged)
            {
                Console.WriteLine(string.Join(' ', list));
            }       
        }
    }
}
