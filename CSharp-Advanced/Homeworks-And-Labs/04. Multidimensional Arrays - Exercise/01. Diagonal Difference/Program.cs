using System;

namespace _01._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            int firstDiagonal = 0;

            for (int row = 0; row < n; row++)
            {
                firstDiagonal += matrix[row, row];                                    
            }

            int secondDiagonal = 0;

            int secondRow = 0;
            int secondCol = n-1;

            for (int i = 0; i < n; i++)
            {
                secondDiagonal += matrix[secondRow, secondCol];
                secondCol--;
                secondRow++;
            }

            Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
        }
    }
}
