using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(num);
            int oddSum = GetSumOfOddDigits(num);
            int multiplied = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(multiplied);
        }

        private static int GetSumOfEvenDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2 == 0)
                {
                    sum += currentNum;
                }
                num = num / 10;
            }
            return sum;
        }

        private static int GetSumOfOddDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int currentNum = num % 10;
                if (currentNum % 2 != 0)
                {
                    sum += currentNum;
                }
                num = num / 10;
            }
            return sum;
        }

        private static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
