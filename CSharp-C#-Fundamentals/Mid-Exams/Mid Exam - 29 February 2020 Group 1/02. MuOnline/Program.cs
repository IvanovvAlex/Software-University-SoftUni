using System;
using System.Linq;

namespace _02._MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoin = 0;

            string[] rooms = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] room = rooms[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (room[0].ToLower())
                {
                    case "potion":
                        if (int.Parse(room[1]) + health <= 100)
                        {
                            health += int.Parse(room[1]);
                            Console.WriteLine($"You healed for {room[1]} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        else
                        {
                            int diff = (health + int.Parse(room[1])) - 100;
                            health = 100;                            
                            Console.WriteLine($"You healed for {int.Parse(room[1]) - diff} hp.");
                            Console.WriteLine($"Current health: {health} hp.");
                        }
                        break;
                    case "chest":
                        bitcoin += int.Parse(room[1]);
                        Console.WriteLine($"You found {int.Parse(room[1])} bitcoins.");
                        break;
                    default:
                        string monsterName = room[0];
                        int damage = int.Parse(room[1]);

                        health -= damage;

                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {monsterName}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {monsterName}.");
                            Console.WriteLine($"Best room: {i+1}");
                            return;
                        }
                        break; 
                }
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoin}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
