using System;
using System.Collections.Generic;

namespace _05._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(firstLine[0]);
            int cols = int.Parse(firstLine[1]);

            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();

            Queue<char> queue = new Queue<char>();

            for (int i = 0; i < snake.Length; i++)
            {
                queue.Enqueue(snake[i]);
            }

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        if (queue.Count == 0)
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }

                        matrix[row, col] = queue.Dequeue();
                    }
                    
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        if (queue.Count == 0)
                        {
                            for (int i = 0; i < snake.Length; i++)
                            {
                                queue.Enqueue(snake[i]);
                            }
                        }
                        matrix[row, col] = queue.Dequeue();
                    }                    
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
