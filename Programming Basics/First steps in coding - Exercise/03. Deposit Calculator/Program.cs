using System;

namespace Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double dep = double.Parse(Console.ReadLine());
            int monts = int.Parse(Console.ReadLine());
            double depro = double.Parse(Console.ReadLine());



            Console.WriteLine(dep + (monts * ((dep * (depro / 100)) / 12)));
        }
    }
}
