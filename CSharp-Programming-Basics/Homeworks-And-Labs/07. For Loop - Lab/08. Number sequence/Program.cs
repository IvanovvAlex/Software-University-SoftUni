using System;
using System.ComponentModel.DataAnnotations;

namespace Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var max = double.MinValue;
            var min = double.MaxValue;

            for (int i = 0; i < n; i++)
            {
                var m = int.Parse(Console.ReadLine());

                if (m > max)
                {
                    max = m;
                }
                if (m < min)
                {
                    min = m;
                }
            }
            Console.WriteLine($"Max number: {max}");
            Console.WriteLine($"Min number: {min}");
        }
    }
}
