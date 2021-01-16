using System;

namespace _01._Sum_Matrix_Elements
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

            int sum = 0;

            for (int row = 0; row < rows; row++)
            {                
                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}
