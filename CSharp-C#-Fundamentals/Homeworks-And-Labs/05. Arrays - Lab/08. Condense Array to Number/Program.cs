using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            if (numArr.Length == 1)
            {
                Console.WriteLine(numArr[0]);
                return;
            }
            int finalResult = 0;
            int firstLength = numArr.Length - 1;

            for (int i = 0; i < firstLength; i++)
            {
                int[] condensedArr = new int[numArr.Length - 1];
                for (int j = 0; j < condensedArr.Length; j++)
                    condensedArr[j] = numArr[j] + numArr[j + 1];
                numArr = condensedArr;
                finalResult = condensedArr[0];
            }
            Console.WriteLine(finalResult);
        }
    }
}
