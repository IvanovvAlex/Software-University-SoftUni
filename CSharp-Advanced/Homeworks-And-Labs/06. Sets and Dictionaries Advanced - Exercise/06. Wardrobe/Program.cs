using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = 
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] firstArr = Console.ReadLine()
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string color = firstArr[0].Substring(0, firstArr[0].Length-1);

                string[] arrWithClothes = firstArr[1]
                    .Split(",", StringSplitOptions.RemoveEmptyEntries);

                arrWithClothes[0] = arrWithClothes[0].Substring(1);

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                foreach (var cloth in arrWithClothes)
                {
                    if (!wardrobe[color].ContainsKey(cloth))
                    {
                        wardrobe[color].Add(cloth, 0);
                    }
                    wardrobe[color][cloth]++;
                }
            }

            string[] lastLine = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string colorSearch = lastLine[0];
            string clothSearch = lastLine[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");
                foreach (var item in color.Value)
                {
                    if (item.Key == clothSearch && color.Key == colorSearch)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }
        }
    }
}
