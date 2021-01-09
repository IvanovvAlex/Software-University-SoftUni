using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string legendaryItem = String.Empty;
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("motes", 0);
            materials.Add("shards", 0);
            materials.Add("fragments", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (materials["motes"] < 250 && materials["fragments"] < 250 && materials["shards"] < 250)
            {
                string input = Console.ReadLine().ToLower();
                string[] inputTokens = input.Split(" ");
                for (int i = 0; i < inputTokens.Length; i += 2)
                {
                    int quantity = int.Parse(inputTokens[i]);
                    string material = inputTokens[i + 1];

                    switch (material)
                    {
                        case "shards":
                        case "fragments":
                        case "motes":
                            materials[material] += quantity;
                            break;
                        default:
                            if (!junk.ContainsKey(material))
                                junk.Add(material, 0);
                            junk[material] += quantity;
                            break;
                    }

                    if (materials["shards"] >= 250 || materials["fragments"] >= 250 || materials["motes"] >= 250)
                        break;
                }
            }

            if (materials["shards"] >= 250)
            {
                legendaryItem = "Shadowmourne";
                materials["shards"] -= 250;
            }
            else if (materials["fragments"] >= 250)
            {
                legendaryItem = "Valanyr";
                materials["fragments"] -= 250;
            }
            else
            {
                legendaryItem = "Dragonwrath";
                materials["motes"] -= 250;
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in materials.OrderByDescending(entry => entry.Value).ThenBy(entry => entry.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(entry => entry.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}