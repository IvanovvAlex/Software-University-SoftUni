using System;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    if (cow > 1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(num);
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (num > n)
                {
                    break;
                }
            }
        }
    }
}
