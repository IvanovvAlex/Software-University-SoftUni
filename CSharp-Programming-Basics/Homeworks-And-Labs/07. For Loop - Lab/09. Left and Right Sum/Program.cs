using System;

namespace Left_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var firstsum = 0;
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                firstsum = firstsum + x;
            }

            var secondsum = 0;
            for (int i = 0; i < n; i++)
            {
                var x = int.Parse(Console.ReadLine());
                secondsum = secondsum + x;
            }
            var diff = Math.Abs(firstsum - secondsum);

            if (firstsum == secondsum)
            {
                Console.WriteLine("Yes, sum = {0}", firstsum);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", diff);
            }
        }
    }
}

