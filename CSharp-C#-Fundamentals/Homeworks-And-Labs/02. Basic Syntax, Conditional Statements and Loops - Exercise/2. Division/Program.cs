using System;

namespace _2._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (num % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
                return;
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
                return;
            }
            else if (num % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
                return;
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
                return;
            }
            else if (num % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
                return;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            
        }
    }
}
