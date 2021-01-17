using System;

namespace _03._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(firstLine[0]);
            int cols = int.Parse(firstLine[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            int biggestSum = 0;
            int biggestRow = 0;
            int biggestCol = 0;

            for (int row = 0; row < rows - 2; row++)
            {
                for (int col = 0; col < cols - 2; col++)
                {
                   int currentSum = 
                        matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        biggestRow = row;
                        biggestCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {biggestSum}");
            Console.WriteLine($"{matrix[biggestRow, biggestCol]} {matrix[biggestRow, biggestCol + 1]} {matrix[biggestRow, biggestCol + 2]}");
            Console.WriteLine($"{matrix[biggestRow + 1, biggestCol]} {matrix[biggestRow + 1, biggestCol + 1]} {matrix[biggestRow + 1, biggestCol + 2]}");
            Console.WriteLine($"{matrix[biggestRow + 2, biggestCol]} {matrix[biggestRow + 2, biggestCol + 1]} {matrix[biggestRow + 2, biggestCol + 2]}");
        }
    }
}
