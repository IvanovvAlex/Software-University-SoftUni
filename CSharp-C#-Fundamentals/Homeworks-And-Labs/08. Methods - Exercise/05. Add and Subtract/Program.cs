using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int result = Subtract(Sum(firstNum, secondNum), thirdNum);
            Console.WriteLine(result);
        }

        static int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        static int Subtract(int sum, int thirdNum)
        {
            return sum - thirdNum;
        }
    }
}
