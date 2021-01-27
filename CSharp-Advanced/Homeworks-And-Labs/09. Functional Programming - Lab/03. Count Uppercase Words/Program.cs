using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> func = IsUppercase;

            List<string> input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => func(x))
                .ToList();

            input.ForEach(x => Console.WriteLine(x));
        }

        static bool IsUppercase(string word)
        {
            byte[] asciiBytes = Encoding.ASCII.GetBytes(word);
            if (asciiBytes[0] >= 65 && asciiBytes[0] <= 90)
            {
                return true;
            }
            return false;
        }
    }
}
