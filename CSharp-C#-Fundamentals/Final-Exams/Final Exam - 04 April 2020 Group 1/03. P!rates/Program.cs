using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> towns =
                new Dictionary<string, Dictionary<string, int>>();

            string command = Console.ReadLine();

            while (command != "Sail")
            {
                string[] tockens = command
                    .Split("||", StringSplitOptions.RemoveEmptyEntries);
                string town = tockens[0];
                int population = int.Parse(tockens[1]);
                int gold = int.Parse(tockens[2]);

                if (towns.ContainsKey(town))
                {
                    towns[town]["population"] += population;
                    towns[town]["gold"] += gold;
                }
                else
                {
                    towns.Add(town, new Dictionary<string, int>()
                    {
                        {"population", population },
                        {"gold", gold}
                    });
                }
                
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                string[] tockens = command
                    .Split("=>", StringSplitOptions.RemoveEmptyEntries);

                switch (tockens[0])
                {
                    case "Plunder":
                        string town = tockens[1];
                        int people = int.Parse(tockens[2]);
                        int goldToRob = int.Parse(tockens[3]);

                        towns[town]["population"] -= people;
                        towns[town]["gold"] -= goldToRob;

                        Console.WriteLine($"{town} plundered! {goldToRob} gold stolen, {people} citizens killed.");
                        if (towns[town]["population"] <= 0 || towns[town]["gold"] <= 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            towns.Remove(town);
                        }

                        break;
                    case "Prosper":
                        if (int.Parse(tockens[2]) > 0)
                        {
                            towns[tockens[1]]["gold"] += int.Parse(tockens[2]);
                            int gold = towns[tockens[1]]["gold"];
                            Console.WriteLine($"{tockens[2]} gold added to the city treasury. {tockens[1]} now has {gold} gold.");
                        }
                        else
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                        }
                        break;
                    
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
            foreach (var town in towns
                .OrderByDescending(v => v.Value["gold"])
                .ThenBy(v => v.Key))
            {
                int people = town.Value["population"];
                int gold = town.Value["gold"];
                Console.WriteLine($"{town.Key} -> Population: {people} citizens, Gold: {gold} kg");
            }
        }
    }
}
