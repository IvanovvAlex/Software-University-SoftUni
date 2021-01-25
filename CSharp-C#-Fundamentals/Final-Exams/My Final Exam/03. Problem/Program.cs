using System;
using System.Linq;
using System.Collections.Generic;


namespace _03._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> people =
                new Dictionary<string, Dictionary<string, int>>();
            int capacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                string[] tockens = command
                    .Split("=", StringSplitOptions.RemoveEmptyEntries);
                switch (tockens[0])
                {
                    case "Add":
                        string name = tockens[1];
                        int sent = int.Parse(tockens[2]);
                        int received = int.Parse(tockens[3]);

                        if (people.ContainsKey(name) == false)
                        {
                            people.Add(name, new Dictionary<string, int>
                            {
                                {"sent", sent },
                                {"received", received }
                            });
                        }                       
                        break;
                    case "Message":
                        string sender = tockens[1];
                        string receiver = tockens[2];
                        if (people.ContainsKey(sender) && people.ContainsKey(receiver))
                        {
                            people[sender]["sent"]++;
                            people[receiver]["received"]++;

                            int sentSender = people[sender]["sent"];
                            int recSender = people[sender]["received"];
                            int totalSender = sentSender + recSender;

                            int sentRec = people[receiver]["sent"];
                            int recRec = people[receiver]["received"];
                            int totalRec = sentRec + recRec;
                            if ( totalSender >= capacity)
                            {
                                Console.WriteLine($"{sender} reached the capacity!");
                                people.Remove(sender);
                            }
                            if (totalRec >= capacity)
                            {
                                Console.WriteLine($"{receiver} reached the capacity!");
                                people.Remove(receiver);
                            }
                        }
                        break;
                    case "Empty":
                        name = tockens[1];
                        if (name == "All")
                        {
                            foreach (var person in people)
                            {
                                people.Remove(person.Key);                                
                            }
                        }
                        else
                        {
                            people.Remove(name);                            
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            
            Console.WriteLine($"Users count: {people.Count}");
            foreach (var person in people.OrderByDescending(r => r.Value["received"])
                .ThenBy(n => n.Key))
            {
                string username = person.Key;
                int messages = person.Value["sent"] + person.Value["received"];
                Console.WriteLine($"{username} - {messages}");
            }
        }
    }
}
