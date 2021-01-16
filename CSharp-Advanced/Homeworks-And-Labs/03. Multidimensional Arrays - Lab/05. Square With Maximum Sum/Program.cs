using System;

namespace _05._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }

            int biggestSum = 0;
            int[] position = new int[2];
            for (int row = 0; row < rows-1; row++)
            {                
                for (int col = 0; col < cols-1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row + 1, col] +
                        matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (currentSum > biggestSum)
                    {
                        biggestSum = currentSum;
                        position[0] = row;
                        position[1] = col;
                    }
                }
            }

            int currentRow = position[0];
            int currentCol = position[1];

            Console.WriteLine($"{matrix[currentRow, currentCol]} {matrix[currentRow, currentCol + 1]}");
            Console.WriteLine($"{matrix[currentRow + 1, currentCol]} { matrix[currentRow + 1, currentCol + 1]}");
            Console.WriteLine($"{biggestSum}");
        }
    }
}
