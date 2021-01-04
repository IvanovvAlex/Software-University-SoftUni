using System;
using System.ComponentModel;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfCalc = Console.ReadLine();
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            switch (typeOfCalc)
            {
                case "add":
                    Add(firstNum, secondNum);
                    break;
                case "multiply":
                    Multiply(firstNum, secondNum);
                    break;
                case "subtract":
                    Subtract(firstNum, secondNum);
                    break;
                case "divide":
                    Divide(firstNum, secondNum);
                    break;
            }
        }

         static void Add(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum+secondNum);
        }

         static void Multiply(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

         static void Subtract(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

         static void Divide(double firstNum, double secondNum)
        {
            Console.WriteLine(firstNum / secondNum);
        }
    }
}
