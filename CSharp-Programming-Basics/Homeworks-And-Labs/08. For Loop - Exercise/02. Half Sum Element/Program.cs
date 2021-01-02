using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var max = int.MinValue;
            var sum = 0;

            for (int i = 0; i < n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                sum += numbers;
                if (numbers > max)
                {
                    max = numbers;
                }

            }

            var diff = Math.Abs((sum - max) - max);
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}", max);
            }
            else if (sum - max != max)
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}", diff);
            }
        }
    }
}
