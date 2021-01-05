using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());
            MinNum(firstNum, secondNum, thirdNum);
        }

        private static void MinNum(double firstNum, double secondNum, double thirdNum)
        {
            double firstMin = Math.Min(firstNum, secondNum);
            double Min = Math.Min(firstMin, thirdNum);
            Console.WriteLine(Min);
        }
    }
}
