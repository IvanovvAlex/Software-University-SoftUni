using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"{Print(firstNum, operation, secondNum)}");
        }

         static int Print(int firstNum, char operation, int secondNum)
        {
            int result = 0;
            switch (operation)
            {
                case '/':
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
            }
            return result;
        }
    }
}
