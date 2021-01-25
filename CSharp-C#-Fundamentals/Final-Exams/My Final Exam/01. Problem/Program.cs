using System;
using System.Linq;

namespace _01._Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Sign up")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Case":
                        if (tokens[1].ToLower() == "upper")
                        {
                            username = username.ToUpper();
                        }
                        else
                        {
                            username = username.ToLower();
                        }
                        Console.WriteLine(username);
                        break;
                    case "Reverse":
                        int startIndex = int.Parse(tokens[1]);
                        int endIndex = int.Parse(tokens[2]) + 1;
                        if (startIndex >= 0 && endIndex < username.Length)
                        {
                            string sub = username.Substring(startIndex, endIndex - startIndex);
                            char[] charArray = sub.ToCharArray();
                            Array.Reverse(charArray);

                            Console.WriteLine(string.Join("", charArray));
                        }                                                
                        break;
                    case "Cut":
                        if (username.Contains(tokens[1]))
                        {
                            username = username.Replace(tokens[1], string.Empty);
                            Console.WriteLine(username);
                        }
                        else
                        {
                            Console.WriteLine($"The word {username} doesn't contain {tokens[1]}.");
                        }
                        break;
                    case "Replace":
                        username = username.Replace(tokens[1], "*");
                        Console.WriteLine(username);
                        break;
                    case "Check":
                        if (username.Contains(tokens[1]))
                        {
                            Console.WriteLine("Valid");
                        }
                        else
                        {
                            Console.WriteLine($"Your username must contain {tokens[1]}.");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
