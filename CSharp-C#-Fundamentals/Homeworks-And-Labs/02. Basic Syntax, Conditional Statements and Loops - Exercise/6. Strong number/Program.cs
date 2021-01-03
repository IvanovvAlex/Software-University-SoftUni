using System;

namespace _6._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numCopy = num;
            int sum = 0;

            while (num != 0)
            {
                int factoriel = 1;
                int number = num % 10;
                num /= 10;
                for (int i = 2; i <= number; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
            }
            if (sum == numCopy)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }


        }
    }
}
