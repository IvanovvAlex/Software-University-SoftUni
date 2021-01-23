using System;
using System.Linq;

namespace _01._World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] tockens = command
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);

                string act = tockens[0];

                switch (act.ToLower())
                {
                    case "add stop":
                        int index = int.Parse(tockens[1]);
                        string insert = tockens[2];
                        if (index >= 0 && index < stops.Length)
                        {
                            stops = stops.Insert(index, insert);                           
                        }
                        Console.WriteLine(stops);
                        break;

                    case "remove stop":
                        int startIndex = int.Parse(tockens[1]);
                        int endIndex = int.Parse(tockens[2]);
                        if (startIndex >= 0 && startIndex < stops.Length && endIndex >= 0 && endIndex < stops.Length)
                        {
                            string firstPart = stops.Substring(0, startIndex);                            
                            string secondPart = stops.Substring(endIndex+1);
                            stops = firstPart + secondPart;                            
                        }
                        Console.WriteLine(stops);
                        break;

                    case "switch":
                        string oldString = tockens[1];
                        string newString = tockens[2];
                        if (stops.Contains(oldString))
                        {
                            stops = stops.Replace(oldString, newString);
                        }                        
                        Console.WriteLine(stops);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
