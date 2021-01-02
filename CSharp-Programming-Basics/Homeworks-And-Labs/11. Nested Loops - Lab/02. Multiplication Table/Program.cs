using Microsoft.VisualBasic;
using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int f = 1; f < 11; f++)
                {
                    Console.WriteLine($"{i} * {f} = {i * f}");
                }
            }
        }
    }
}
