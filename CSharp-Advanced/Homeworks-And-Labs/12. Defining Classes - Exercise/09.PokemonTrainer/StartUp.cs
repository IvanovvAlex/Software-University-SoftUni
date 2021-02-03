using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (string.Join(" ", line) != "Tournament")
            {
                string trainerName = line[0];
                string pokemonName = line[1];
                string pokemonElement = line[2];
                int pokemonHealth = int.Parse(line[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName, new List<Pokemon>
                    { new Pokemon(pokemonName, pokemonElement, pokemonHealth) }));
                }
                else
                {
                    trainers[trainerName].Pokemons.Add
                        (new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }

                line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "Fire":
                        foreach (var trainer in trainers)
                        {
                            bool elementChecker = false;
                            foreach (var pokemon in trainer.Value.Pokemons)
                            {
                                if (pokemon.Element == "Fire")
                                {
                                    elementChecker = true;
                                }
                            }
                            if (elementChecker)
                            {
                                trainer.Value.NumOfBadges++;
                            }
                            else
                            {
                                for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                                {
                                    trainer.Value.Pokemons[i].Health -= 10;
                                    if (trainer.Value.Pokemons[i].Health <= 0)
                                    {
                                        trainer.Value.Pokemons.RemoveAt(i);
                                        i--;
                                    }
                                }
                            }
                        }
                        break;
                    case "Water":
                        foreach (var trainer in trainers)
                        {
                            bool elementChecker = false;
                            foreach (var pokemon in trainer.Value.Pokemons)
                            {
                                if (pokemon.Element == "Water")
                                {
                                    elementChecker = true;
                                }
                            }
                            if (elementChecker)
                            {
                                trainer.Value.NumOfBadges++;
                            }
                            else
                            {
                                for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                                {
                                    trainer.Value.Pokemons[i].Health -= 10;
                                    if (trainer.Value.Pokemons[i].Health <= 0)
                                    {
                                        trainer.Value.Pokemons.RemoveAt(i);
                                        i--;
                                    }
                                }
                            }
                        }
                        break;
                    case "Electricity":
                        foreach (var trainer in trainers)
                        {
                            bool elementChecker = false;
                            foreach (var pokemon in trainer.Value.Pokemons)
                            {
                                if (pokemon.Element == "Electricity")
                                {
                                    elementChecker = true;
                                }
                            }
                            if (elementChecker)
                            {
                                trainer.Value.NumOfBadges++;
                            }
                            else
                            {
                                for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                                {
                                    trainer.Value.Pokemons[i].Health -= 10;
                                    if (trainer.Value.Pokemons[i].Health <= 0)
                                    {
                                        trainer.Value.Pokemons.RemoveAt(i);
                                        i--;
                                    }
                                }                                
                            }
                        }
                        break;
                }                
                command = Console.ReadLine();
            }
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumOfBadges))
            {
                Console.WriteLine($"{trainer.Value.Name} {trainer.Value.NumOfBadges} {trainer.Value.Pokemons.Count}");
            }
        }
    }
}
