using System;

namespace _05.GenericCountMethodString
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            string comparisonElement = Console.ReadLine();
            Console.WriteLine(box.GetGreaterElementsCount(comparisonElement));
        }
    }
}
