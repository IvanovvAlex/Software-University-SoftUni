using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((=)|(\/))(?<name>[A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            Regex reg = new Regex(pattern);
            MatchCollection validDest = reg.Matches(input);
            int points = 0;
            List<string> list = new List<string>();
            foreach (Match dest in validDest)
            {
                string name = dest.Groups["name"]
                    .ToString();
                list.Add(name);
                points += dest.Value.Length-2;
            }

            Console.WriteLine($"Destinations: {string.Join(", ", list)}");            
            Console.WriteLine($"Travel Points: {points}");
        }
    }
}
