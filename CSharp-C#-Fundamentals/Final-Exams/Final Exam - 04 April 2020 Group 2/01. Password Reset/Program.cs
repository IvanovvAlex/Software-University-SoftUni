using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] tockens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                switch (tockens[0])
                {

                    case "TakeOdd":
                        List<char> workPass = pass
                            .ToList();
                        List<char> finalWord = new List<char>();
                        for (int i = 1; i < workPass.Count; i+=2)
                        {
                            finalWord.Add(workPass[i]);
                        }
                        pass = string.Join("", finalWord);
                        Console.WriteLine(pass);
                        break;

                    case "Cut":
                        int index = int.Parse(tockens[1]);
                        int length = int.Parse(tockens[2]);
                        List<char> cutWord = pass
                            .ToList();
                        for (int i = 0; i < length; i++)
                        {
                            cutWord.RemoveAt(index);
                        }
                        pass = string.Join("", cutWord);
                        Console.WriteLine(pass);
                        break;

                    case "Substitute":
                        if (pass.Contains(tockens[1]))
                        {
                            pass = pass.Replace(tockens[1], tockens[2]);
                            Console.WriteLine(pass);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {pass}");
        }
    }
}
