using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int triangleSize = TriangleSize();
            PrintHeader(triangleSize);
            PrintFooter(triangleSize);
        }

        
        static int TriangleSize()
        {
            int triangleSize = int.Parse(Console.ReadLine());
            return triangleSize;
        }
         static void PrintHeader(int triangleSize)
        {
            for (int i = 1; i <= triangleSize; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
        private static void PrintFooter(int triangleSize)
        {
            for (int i = triangleSize - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

    }
}
