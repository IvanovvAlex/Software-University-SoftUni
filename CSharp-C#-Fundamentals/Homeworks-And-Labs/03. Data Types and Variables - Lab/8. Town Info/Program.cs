using System;

namespace _8._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            uint area = uint.Parse(Console.ReadLine());
            Console.WriteLine($"Town {name} has population of {population} and area {area} square km.");
        }
    }
}
