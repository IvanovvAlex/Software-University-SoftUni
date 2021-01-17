using System;

namespace _04._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            int rows = int.Parse(firstLine[0]);
            int cols = int.Parse(firstLine[1]);

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "END")
                {
                    break;
                }

                try
                {
                    int firstRow = int.Parse(input[1]);
                    int firstCol = int.Parse(input[2]);
                    int secondRow = int.Parse(input[3]);
                    int secondCol = int.Parse(input[4]);

                    string first = matrix[firstRow, firstCol];
                    string second = matrix[secondRow, secondCol];

                    matrix[firstRow, firstCol] = second;
                    matrix[secondRow, secondCol] = first;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row, col] + ' ');
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }                
            }
        }
    }
}
