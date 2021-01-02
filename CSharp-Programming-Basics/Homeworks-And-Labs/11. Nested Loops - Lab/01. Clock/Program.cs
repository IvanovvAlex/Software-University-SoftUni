using System;
using System.Diagnostics.CodeAnalysis;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int f = 0; f < 60; f++)
                {
                    Console.WriteLine($"{i}:{f}");
                }
            }
        }
    }
}
