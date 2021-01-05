using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            double firstFactorial = FindFirstFactorial(firstNum);
            double secondFactorial = FindSecondFactorial(secondNum);
            Console.WriteLine($"{(firstFactorial/secondFactorial):f2}");
        }

         static double FindSecondFactorial(double secondNum)
        {
            double secondFactorial = 0d;
            if (secondNum != 1)
            {             
                 secondFactorial = secondNum * (secondNum - 1);
                for (double i = secondNum - 2; i >= 1; i--)
                {
                    secondFactorial *= i;
                }
                
            }
            if (secondNum == 1)
            {
                 secondFactorial = 1;         
               
            }
            return secondFactorial;
        }

        static double FindFirstFactorial(double firstNum)
        {
            double firstFactorial = 0d;
            if (firstNum != 1)
            {
                firstFactorial = firstNum * (firstNum - 1);
                for (double i = firstNum - 2; i >= 1; i--)
                {
                    firstFactorial *= i;
                }
            }
            if (firstNum == 1)
            {
                firstFactorial = 1;
            }
            
            return firstFactorial;          
        }
    }
}
