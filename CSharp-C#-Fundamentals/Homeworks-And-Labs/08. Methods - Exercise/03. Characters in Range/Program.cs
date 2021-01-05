using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            Print(firstChar, secondChar);
        }

         static void Print(char firstChar, char secondChar)
        {
            if (firstChar > secondChar)
            {
                for (int i = secondChar + 1; i < firstChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = firstChar + 1; i < secondChar; i++)
                {
                    Console.Write($"{(char)i} ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
