using System;
using System.Collections.Generic;

namespace _02._Sum_Matrix_Columns
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
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }
            Queue<int> queue = new Queue<int>();
            for (int col = 0; col < cols; col++)
            {
                int colSum = 0;
                for (int row = 0; row < rows; row++)
                {
                    colSum += matrix[row, col];
                }
                queue.Enqueue(colSum);
            }
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}
