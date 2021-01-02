using System;

namespace Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int smaller = int.Parse(Console.ReadLine());
            int bigger = int.Parse(Console.ReadLine());

            for (int i = smaller; i <= bigger; i++)
            {
                // number of symbols in each number
                string num = i.ToString();
                int length = num.Length;

                int evenSum = 0;
                int oddSum = 0;
                int process = i;


                for (int ii = 0; ii < length; ii++)
                {
                    // use moduls to separate the numbers
                    int modul = process % 10;

                    // odd or even position
                    if ((ii + 1) % 2 == 0)
                    {
                        // even position
                        evenSum += modul;
                    }
                    else
                    {
                        // odd sum
                        oddSum += modul;
                    }

                    process = (process - modul) / 10;
                }

                // compare sums
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
