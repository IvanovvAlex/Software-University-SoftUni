using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<word>[A-Za-z]{8,})\]";
            Regex reg = new Regex(pattern);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matches = reg.Matches(input);
                if (matches.Count == 0)
                {
                    Console.WriteLine("The message is invalid");
                }
                else
                {
                    foreach (Match match in matches)
                    {
                        string word = match.Groups["word"].Value;
                        string command = match.Groups["command"].Value;
                        //char[] arr = word                            
                        //    .ToArray();
                        byte[] asciiBytes = Encoding.ASCII.GetBytes(word);
                        //foreach (var item in arr)
                        //{
                        //    item.
                        //}
                        Console.WriteLine($"{command}: {string.Join(" ", asciiBytes)}");
                    }
                }
            }
        }
    }
}
