using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[0-9]";

            string[] names = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> statistic = new Dictionary<string, int>();

            foreach (var name in names)
            {
                statistic.Add(name, 0);
            }

            string command = Console.ReadLine();

            while (command != "end of race")
            {
                MatchCollection letters = Regex.Matches(command, namePattern);
                StringBuilder nameBuild = new StringBuilder();
                foreach (Match letter in letters)
                {
                    nameBuild.Append(letter.Value);
                }
                string name = nameBuild.ToString();
                if (statistic.ContainsKey(name))
                {
                    MatchCollection digits = Regex.Matches(command, distancePattern);
                    int distance = 0;
                    foreach (Match meter in digits)
                    {
                        distance += int.Parse(meter.Value);
                    }
                    statistic[name] += distance;
                }
                command = Console.ReadLine();
            }


            string[] list = new string[] { "first", "second", "third" };
            int i = 0;
            foreach (KeyValuePair<string, int> people in statistic.OrderByDescending(key => key.Value))
            {
                list[i] = people.Key;
                i++;
                if (i == 3)
                {
                    Console.WriteLine($"1st place: {list[0]}");
                    Console.WriteLine($"2nd place: {list[1]}");
                    Console.WriteLine($"3rd place: {list[2]}");
                    return;
                }
            }
        }
    }
}
