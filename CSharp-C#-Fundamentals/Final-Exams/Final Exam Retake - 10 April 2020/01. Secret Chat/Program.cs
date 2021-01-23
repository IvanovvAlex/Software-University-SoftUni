using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hidenMessage = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Reveal")
            {
                string[] tockens = command
                    .Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                switch (tockens[0])
                {
                    case "InsertSpace":
                        int index = int.Parse(tockens[1]);
                        hidenMessage = hidenMessage.Insert(index, " ");
                        Console.WriteLine(hidenMessage);
                        break;
                    case "Reverse":
                        string subS = tockens[1];
                        if (hidenMessage.Contains(subS))
                        {
                            int lenght = tockens[1].Length;
                            int startIndex = hidenMessage.IndexOf(tockens[1]);
                           
                            char[] reversedArr = tockens[1]
                                .Reverse()
                                .ToArray();
                            string reversedString = string.Join("", reversedArr);


                            hidenMessage = hidenMessage.Remove(startIndex, lenght);
                            hidenMessage = hidenMessage += reversedString;
                            Console.WriteLine(hidenMessage);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        subS = tockens[1];
                        if (hidenMessage.Contains(subS))
                        {
                            string newS = tockens[2];
                            hidenMessage = hidenMessage.Replace(subS, newS);
                            Console.WriteLine(hidenMessage);
                        }                        
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {hidenMessage}");
        }
    }
}
