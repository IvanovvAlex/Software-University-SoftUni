using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int area = AreaCalc(width, height);
            Console.WriteLine(area);
        }

         static int AreaCalc(int width, int height)
        {
            return width * height;
        }
    }
}
