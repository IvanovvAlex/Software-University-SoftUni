using System;

namespace Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double firstCalc = length * width * height;
            double secondCalc = firstCalc * 0.001;
            double procentCalc = procent * 0.01;
            double totalLitres = secondCalc - (secondCalc * procentCalc);
            Console.WriteLine(totalLitres);
        }
    }
}
