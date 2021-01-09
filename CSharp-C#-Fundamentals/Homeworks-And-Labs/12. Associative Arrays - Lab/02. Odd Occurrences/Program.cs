using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (var word in words)
            {
                string wordToLower = word.ToLower();
                if (result.ContainsKey(wordToLower))
                {
                    result[wordToLower]++;
                }
                else
                {
                    result.Add(wordToLower, 1);
                }
            }

            foreach (var word in result)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write($"{word.Key} ");
                }
            }
            
        }
    }
}
