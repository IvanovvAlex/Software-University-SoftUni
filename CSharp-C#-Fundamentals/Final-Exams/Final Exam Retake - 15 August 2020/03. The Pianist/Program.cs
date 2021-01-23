using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> pieces =
                new Dictionary<string, Dictionary<string, string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] forLoopCommand = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string piece = forLoopCommand[0];
                string composer = forLoopCommand[1];
                string key = forLoopCommand[2];
                pieces.Add(piece, new Dictionary<string, string>
                            {
                                {"composer", composer },
                                {"key", key }
                            });
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] tokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string act = tokens[0];
                string piece = tokens[1];

                switch (act)
                {
                    case "Add":
                        string composer = tokens[2];
                        string key = tokens[3];

                        if (pieces.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            pieces.Add(piece, new Dictionary<string, string>
                            {
                                {"composer", composer },
                                {"key", key }
                            });
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        key = tokens[2];
                        if (pieces.ContainsKey(piece))
                        {
                            pieces[piece]["key"] = key;
                            Console.WriteLine($"Changed the key of {piece} to {key}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var piece in pieces.OrderBy(k => k.Key)
                .ThenBy(c => c.Value["composer"]))
            {
                string composer = piece.Value["composer"];
                string key = piece.Value["key"];
                Console.WriteLine($"{piece.Key} -> Composer: {composer}, Key: {key}");
            }
        }
    }
}
