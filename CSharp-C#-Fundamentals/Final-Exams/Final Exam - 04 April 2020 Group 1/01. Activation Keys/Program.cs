using System;

namespace _01._Activation_Keys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();

            string command = Console.ReadLine();
            while (command != "Generate")
            {
                string[] tockens = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                switch (tockens[0])
                {
                    case "Contains":
                        if (rawKey.Contains(tockens[1]))
                        {
                            Console.WriteLine($"{rawKey} contains {tockens[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                    case "Flip":
                        int startIndex = int.Parse(tockens[2]);
                        int endIndex = int.Parse(tockens[3]);
                        string firstPart = rawKey.Substring(0, startIndex);
                        string secondPart = rawKey.Substring(startIndex, endIndex - startIndex);
                        string thirdPart = rawKey.Substring(endIndex);

                        if (tockens[1] == "Upper")
                        {
                            secondPart = secondPart.ToUpper();
                        }
                        else
                        {
                            secondPart = secondPart.ToLower();
                        }

                        rawKey = firstPart + secondPart + thirdPart;
                        Console.WriteLine(rawKey);
                        break;
                    case "Slice":
                        startIndex = int.Parse(tockens[1]);
                        endIndex = int.Parse(tockens[2]);

                        firstPart = rawKey.Substring(0, startIndex);
                        secondPart = rawKey.Substring(startIndex, endIndex - startIndex);
                        thirdPart = rawKey.Substring(endIndex);
                        secondPart = string.Empty;
                        rawKey = firstPart + secondPart + thirdPart;
                        Console.WriteLine(rawKey);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
