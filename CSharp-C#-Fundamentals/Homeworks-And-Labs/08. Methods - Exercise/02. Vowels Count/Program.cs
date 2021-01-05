using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            VowelsCounter(text);
        }

         static void VowelsCounter(string text)
        {
            int sumA = 0;
            int sumE = 0;
            int sumI = 0;
            int sum0 = 0;
            int sumU = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sumA++;
                }
                else if (text[i] == 'e')
                {
                    sumE++;
                }
                else if (text[i] == 'i')
                {
                    sumI++;
                }
                else if (text[i] == 'o')
                {
                    sum0++;
                }
                else if (text[i] == 'u')
                {
                    sumU++;
                }
            }
            Console.WriteLine(sumA + sumE + sumI + sum0 + sumU);
        }
    }
}
