using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = double.Parse(Console.ReadLine());
            if (speed <= 10.0)
            {
                Console.WriteLine("slow");
            }
            else if (10.0 < speed && speed <= 50.0)
            {
                Console.WriteLine("average");
            }
            else if (50.0 < speed && speed <= 150.0)
            {
                Console.WriteLine("fast");
            }
            else if (150.0 < speed && speed <= 1000.0)
            {
                Console.WriteLine("ultra fast");
            }
            else if (speed > 1000.0)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
