using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int f = 1; f <= 9; f++)
                {
                    for (int g = 1; g <= 9; g++)
                    {
                        for (int d = 1; d <= 9; d++)
                        {
                            if (n % i == 0 && n % f == 0 && n % g == 0 && n % d == 0)
                            {
                                Console.Write($"{i}{f}{g}{d} ");
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
