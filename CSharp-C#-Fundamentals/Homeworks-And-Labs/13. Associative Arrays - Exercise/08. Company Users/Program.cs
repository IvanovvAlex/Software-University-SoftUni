using System;
using System.Collections.Generic;
using System.Linq;


namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new SortedDictionary<string, List<string>>();

            string[] firstCommand = Console.ReadLine()
                .Split(" -> ")
                .ToArray();
            while (firstCommand[0] != "End")
            {
                string[] command = firstCommand;

                string company = command[0];
                string id = command[1];

                if (list.ContainsKey(company))
                {
                    if (list[company].Contains(id) == false)
                    {
                        list[company].Add(id);
                    }
                }
                else
                {
                    list.Add(company, new List<string>());
                    list[company].Add(id);
                }

                firstCommand = Console.ReadLine()
                .Split(" -> ")
                .ToArray();
            }
            foreach (var company in list)
            {
                
                Console.WriteLine($"{company.Key}");
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
