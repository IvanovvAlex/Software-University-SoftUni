using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Print(num);
        }

         static void Print(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                bool devisibleBy8 = DevisibleBy8(i);
                bool moreThanOneOddNum = MoreThanOneOddNum(i);
                if (devisibleBy8 == true && moreThanOneOddNum == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

         static bool MoreThanOneOddNum(int i)
        {
            bool trueOrNot = false;
            while (i > 0)
            {
                int lastDigit = i % 10;
                if (lastDigit % 2 != 0)
                {
                    trueOrNot = true;
                    return trueOrNot;
                }
                i = i / 10;
            }
            return trueOrNot;
        }

         static bool DevisibleBy8(int i)
        {
            bool trueOrNot = false;
            int sum = 0;
            while (i > 0)
            {
               int currentDigit = i % 10;
                sum += currentDigit;
                i /= 10;
            }
            if (sum % 8 == 0)
            {
                trueOrNot = true;
            }
            else
            {
                trueOrNot = false;
            }
            return trueOrNot;
        }
    }
}
