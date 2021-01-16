using System;

namespace _04._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            char searchFor = char.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {                
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == searchFor)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{searchFor} does not occur in the matrix");
        }
    }
}
