using System;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<double> box = new Box<double>();
            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double comparisonElement = double.Parse(Console.ReadLine());
            Console.WriteLine(box.GetGreaterElementsCount(comparisonElement));
        }
    }
}
