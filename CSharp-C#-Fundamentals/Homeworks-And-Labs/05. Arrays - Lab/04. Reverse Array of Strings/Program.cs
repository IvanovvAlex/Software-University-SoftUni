using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] elements = line
                .Split()
                .ToArray();

            Console.Write(string.Join(' ', elements.Reverse()));

        }
    }
}
