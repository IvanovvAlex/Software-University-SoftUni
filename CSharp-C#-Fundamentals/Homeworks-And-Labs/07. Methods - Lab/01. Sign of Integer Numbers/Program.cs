using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = NumReading();
            Print(NumTypeFinding(num), num);
        }
        
        static int NumReading()
        {
            int num = int.Parse(Console.ReadLine());
            return num;
        }

         static string NumTypeFinding(int num)
        {
            string type = string.Empty;
            if (num > 0)
            {
                type = "positive";
            }
            else if (num < 0)
            {
                type = "negative";
            }
            else
            {
                type = "zero";
            }
            return type;
        }

         static void Print(string type, int num)
        {
            Console.WriteLine($"The number {num} is {type}.");
        }

    }
}
