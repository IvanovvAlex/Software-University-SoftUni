using System;
using System.Dynamic;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            int poweredNum = NumPowering(num, power);
            Console.WriteLine(poweredNum);
        }

         static int NumPowering(int num, int power)
        {
            int poweredNum = num * num;
            for (int i = 0; i < power-2; i++)
            {
                poweredNum *= num;
            }
            return poweredNum;
        }
    }
}
