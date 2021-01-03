using System;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + n; i++)
            {
                for (char f = 'a'; f < 'a' + n; f++)
                {
                    for (char j = 'a'; j < 'a' + n; j++)
                    {
                        Console.WriteLine($"{i}{f}{j}");
                    }
                }
            }
        }
    }
}
