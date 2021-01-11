using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> validUsernames = new List<string>();

            foreach (var username in input)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isAvalible = true;
                    foreach (var symb in username)
                    {
                        if (Char.IsLetterOrDigit(symb) || symb == '-' || symb == '_')
                        {
                            continue;
                        }
                        else
                        {
                            isAvalible = false;
                        }
                    }
                    if (isAvalible)
                    {
                        validUsernames.Add(username);
                    }
                }
            }
            foreach (var username in validUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
