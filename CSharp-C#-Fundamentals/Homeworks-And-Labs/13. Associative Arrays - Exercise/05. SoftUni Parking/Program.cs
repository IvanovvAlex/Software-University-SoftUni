using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var parking = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = line[0];
                string username = line[1];


                switch (command)
                {
                    case "register":
                        string number = line[2];
                        try
                        {
                            parking.Add(username, number);
                            Console.WriteLine($"{username} registered {number} successfully");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[username]}");
                            //throw;
                        }
                        break;
                    case "unregister":
                       
                            if (parking.ContainsKey(username))
                            {
                                parking.Remove(username);
                                Console.WriteLine($"{username} unregistered successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: user {username} not found");
                            }

                        break;
                }
            }
            foreach (var people in parking)
            {
                Console.WriteLine($"{people.Key} => {people.Value}");
            }
        }
    }
}
