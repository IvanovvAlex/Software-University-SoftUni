using System;

namespace Rad2Deg
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = double.Parse(Console.ReadLine());
            var deg = Math.Round((180 / Math.PI) * rad);
            Console.WriteLine(deg);
        }
    }
}
