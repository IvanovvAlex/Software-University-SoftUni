using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> plants =
                new Dictionary<string, Dictionary<string, double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] foorLoopCommand = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string name = foorLoopCommand[0];
                double rarity = double.Parse(foorLoopCommand[1]);
                if (plants.ContainsKey(name))
                {
                    plants[name]["rarity"] = rarity;
                }
                else
                {
                    plants.Add(name, new Dictionary<string, double>
                    {
                        { "rarity", rarity},
                        { "count", 0},
                        { "rate", 0}
                    });
                }
            }
            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] tockens = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string act = tockens[0];

                tockens = tockens[1]
                    .ToString()
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name = tockens[0];
                name = name.Remove(0, 1);
                switch (act)
                {
                    case "Rate":
                        if (plants.ContainsKey(name))
                        {
                            plants[name]["rate"] += double.Parse(tockens[1]);
                            plants[name]["count"]++;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }


                        break;

                    case "Update":
                        if (plants.ContainsKey(name))
                        {
                            plants[name]["rarity"] = double.Parse(tockens[1]);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "Reset":
                        if (plants.ContainsKey(name))
                        {
                            plants[name]["rate"] = 0;
                            plants[name]["count"] = 0;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(r => r.Value["rarity"])
                .ThenByDescending(v => v.Value["rate"]))
            {
                double rarity = plant.Value["rarity"];
                double rate = plant.Value["rate"];
                double count = plant.Value["count"];
                if (rate == 0)
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {rarity}; Rating: 0.00");
                }
                else
                {
                    Console.WriteLine($"- {plant.Key}; Rarity: {rarity}; Rating: {rate / count:f2}");
                }
                
            }
        }
    }
}
