using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] tokens = command
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string act = tokens[0];

                switch (act)
                {
                    case "Move":
                        int repeats = int.Parse(tokens[1]);
                        for (int i = 0; i < repeats; i++)
                        {
                            char letter = message[0];
                            message = message.Remove(0, 1);
                            message += letter;
                        }
                        break;

                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string value = tokens[2];
                        message = message.Insert(index, value);
                        break;

                    case "ChangeAll":
                        string oldString = tokens[1];
                        string newString = tokens[2];
                        message = message.Replace(oldString, newString);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
