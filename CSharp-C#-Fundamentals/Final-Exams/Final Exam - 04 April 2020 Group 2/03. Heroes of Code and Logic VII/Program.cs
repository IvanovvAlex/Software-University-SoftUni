using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> heroes = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] forLoopCommand = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = forLoopCommand[0];
                int hp = int.Parse(forLoopCommand[1]);
                int mp = int.Parse(forLoopCommand[2]);
                if (hp > 100)
                {
                    hp = 100;
                }
                if (mp > 200)
                {
                    mp = 200;
                }
                heroes.Add(name, new Dictionary<string, int>
                {
                    {"hp", hp },
                    {"mp", mp}
                });
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tockens = command
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string name = tockens[1];

                switch (tockens[0])
                {
                    case "CastSpell":
                        if (heroes[name]["mp"] >= int.Parse(tockens[2]))
                        {
                            heroes[name]["mp"] -= int.Parse(tockens[2]);
                            int mpLeft = heroes[name]["mp"];
                            Console.WriteLine($"{name} has successfully cast {tockens[3]} and now has {mpLeft} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{name} does not have enough MP to cast {tockens[3]}!");
                        }
                        break;
                    case "TakeDamage":
                        heroes[name]["hp"] -= int.Parse(tockens[2]);
                        int hpLeft = heroes[name]["hp"];
                        if (heroes[name]["hp"] > 0)
                        {
                            Console.WriteLine($"{name} was hit for {int.Parse(tockens[2])} HP by {tockens[3]} and now has {hpLeft} HP left!");
                        }
                        else
                        {
                            heroes.Remove(name);
                            Console.WriteLine($"{name} has been killed by {tockens[3]}!");
                        }
                        break;
                    case "Recharge":
                        int mpToAdd = int.Parse(tockens[2]);
                        if (heroes[name]["mp"] + mpToAdd <= 200)
                        {
                            heroes[name]["mp"] += mpToAdd;
                            int currentMp = heroes[name]["mp"];
                            Console.WriteLine($"{name} recharged for {mpToAdd} MP!");
                        }
                        else
                        {
                            
                            int lastMp = heroes[name]["mp"];
                            heroes[name]["mp"] = 200;
                            int currentMp = heroes[name]["mp"];
                            Console.WriteLine($"{name} recharged for {currentMp-lastMp} MP!");
                        }
                        break;
                    case "Heal":
                        int hpToAdd = int.Parse(tockens[2]);
                        if (heroes[name]["hp"] + hpToAdd <= 100)
                        {
                            heroes[name]["hp"] += hpToAdd;
                            int currentHp = heroes[name]["hp"];
                            Console.WriteLine($"{name} healed for {hpToAdd} HP!");
                        }
                        else
                        {

                            int lastHp = heroes[name]["hp"];
                            heroes[name]["hp"] = 100;
                            int currentHp = heroes[name]["hp"];
                            Console.WriteLine($"{name} healed for {currentHp - lastHp} HP!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var hero in heroes
                .OrderByDescending(v => v.Value["hp"])
                .ThenBy(v => v.Key))
            {
                int hp = hero.Value["hp"];
                int mp = hero.Value["mp"];
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hp}");
                Console.WriteLine($"  MP: {mp}");
            }
        }
    }
}
