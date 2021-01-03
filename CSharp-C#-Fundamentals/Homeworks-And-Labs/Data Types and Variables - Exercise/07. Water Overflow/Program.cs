using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int litersInTank = 0;
            for (int i = 0; i < lines; i++)
            {
                int litersToAdd = int.Parse(Console.ReadLine());
                if (litersInTank + litersToAdd <= 255 )
                {
                    litersInTank += litersToAdd;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine($"{litersInTank}");
        }
    }
}
