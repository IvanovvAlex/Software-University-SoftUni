using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Print(num);
        }

         static void Print(int num)
        {
            for (int i = 0; i < num; i++)
            {
                PrintLine(num);
            }          
        }

         static void PrintLine(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}
