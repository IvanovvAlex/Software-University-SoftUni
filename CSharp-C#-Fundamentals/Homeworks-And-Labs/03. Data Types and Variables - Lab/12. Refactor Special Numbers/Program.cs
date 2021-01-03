using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
                       
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int currentNum = 0;
                currentNum = i;
                while (currentNum > 0)
                {
                    sumOfDigits += currentNum % 10;
                    currentNum = currentNum / 10;
                }
                bool specialOrNot = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine("{0} -> {1}", i, specialOrNot);
            }

        }
    }
}
