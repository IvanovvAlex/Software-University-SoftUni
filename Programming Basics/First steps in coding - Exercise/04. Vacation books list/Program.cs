using System;

namespace Vacation_books_list
{
    class Program
    {
        static void Main(string[] args)
        {
            int br = int.Parse(Console.ReadLine());
            double brp = double.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine((br / brp) / d);

        }
    }
}
