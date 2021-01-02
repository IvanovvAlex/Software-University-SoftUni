using System;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < firstnum)
            {
                int secondnum = int.Parse(Console.ReadLine());
                sum += secondnum;
            }
            Console.WriteLine(sum);
        }
    }
}
