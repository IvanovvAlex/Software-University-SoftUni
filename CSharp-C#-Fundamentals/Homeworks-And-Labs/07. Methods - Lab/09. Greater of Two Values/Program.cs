using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int bigger = GetMax(first, second);
                Console.WriteLine(bigger);
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char bigger = GetMax(first, second);
                Console.WriteLine(bigger);
            }
            else
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string bigger = GetMax(first, second);
                Console.WriteLine(bigger);
            }
        }

         static int GetMax(int first, int second)
        {
            return Math.Max(first, second);
        }

         static char GetMax(char first, char second)
        {
            char bigger = (char)0x00;
            if (first > second)
            {
                bigger = first;
            }
            else
            {
                bigger = second;
            }
            return bigger;
        }

         static string GetMax(string first, string second)
        {
            string bigger = string.Empty;
            if (first.CompareTo(second) >= 0)
            {
                bigger = first;
            }
            else
            {
                bigger = second;
            }
            return bigger;
        }
    }
}
