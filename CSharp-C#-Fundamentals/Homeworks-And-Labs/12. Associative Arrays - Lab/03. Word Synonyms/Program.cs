using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeats = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();

            for (int i = 0; i < repeats; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                if (result.ContainsKey(word))
                {
                    result[word].Add(synonym);
                }
                else
                {
                    result.Add(word, new List<string>() { synonym });
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
