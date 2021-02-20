using System;
using System.Linq;

namespace _02Warships
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            string[] coordinates = Console.ReadLine()
                .Split(',', StringSplitOptions.RemoveEmptyEntries);

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;
            int ripShips = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] currentRow = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (currentRow[col] == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (currentRow[col] == '>')
                    {
                        secondPlayerShips++;
                    }
                }
            }

            for (int i = 0; i < coordinates.Length; i++)
            {
                int[] currentCoordinates = coordinates[i]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currentRow = currentCoordinates[0];
                int currentCol = currentCoordinates[1];

                if (!IndexExists(currentRow, currentCol, matrix))
                {
                    continue;
                }

                if (matrix[currentRow, currentCol] == '*')
                {
                    continue;
                }
                else if (matrix[currentRow, currentCol] == '<')
                {
                    matrix[currentRow, currentCol] = 'X';
                    firstPlayerShips--;
                    ripShips++;
                }
                else if (matrix[currentRow, currentCol] == '>')
                {
                    matrix[currentRow, currentCol] = 'X';
                    secondPlayerShips--;
                    ripShips++;
                }
                else if (matrix[currentRow, currentCol] == '#')
                {
                    if (IndexExists(currentRow - 1, currentCol - 1, matrix))
                    {
                        if (matrix[currentRow - 1, currentCol - 1] == '<')
                        {
                            matrix[currentRow - 1, currentCol - 1] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow - 1, currentCol - 1] == '>')
                        {
                            matrix[currentRow - 1, currentCol - 1] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow - 1, currentCol, matrix))
                    {
                        if (matrix[currentRow - 1, currentCol] == '<')
                        {
                            matrix[currentRow - 1, currentCol] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow - 1, currentCol] == '>')
                        {
                            matrix[currentRow - 1, currentCol] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow - 1, currentCol + 1, matrix))
                    {
                        if (matrix[currentRow - 1, currentCol + 1] == '<')
                        {
                            matrix[currentRow - 1, currentCol + 1] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow - 1, currentCol + 1] == '>')
                        {
                            matrix[currentRow - 1, currentCol + 1] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow, currentCol - 1, matrix))
                    {
                        if (matrix[currentRow, currentCol - 1] == '<')
                        {
                            matrix[currentRow, currentCol - 1] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow, currentCol - 1] == '>')
                        {
                            matrix[currentRow, currentCol - 1] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow, currentCol + 1, matrix))
                    {
                        if (matrix[currentRow, currentCol + 1] == '<')
                        {
                            matrix[currentRow, currentCol + 1] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow, currentCol + 1] == '>')
                        {
                            matrix[currentRow, currentCol + 1] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow + 1, currentCol - 1, matrix))
                    {
                        if (matrix[currentRow + 1, currentCol - 1] == '<')
                        {
                            matrix[currentRow + 1, currentCol - 1] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow + 1, currentCol - 1] == '>')
                        {
                            matrix[currentRow + 1, currentCol - 1] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow + 1, currentCol, matrix))
                    {
                        if (matrix[currentRow + 1, currentCol] == '<')
                        {
                            matrix[currentRow + 1, currentCol] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow + 1, currentCol] == '>')
                        {
                            matrix[currentRow + 1, currentCol] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }

                    if (IndexExists(currentRow + 1, currentCol + 1, matrix))
                    {
                        if (matrix[currentRow + 1, currentCol + 1] == '<')
                        {
                            matrix[currentRow + 1, currentCol + 1] = 'X';
                            firstPlayerShips--;
                            ripShips++;
                        }
                        else if (matrix[currentRow + 1, currentCol + 1] == '>')
                        {
                            matrix[currentRow + 1, currentCol + 1] = 'X';
                            secondPlayerShips--;
                            ripShips++;
                        }
                    }
                }

                if (firstPlayerShips == 0 || secondPlayerShips == 0)
                {
                    break;
                }
            }

            if (firstPlayerShips == 0)
            {
                Console.WriteLine($"Player Two has won the game! " +
                    $"{ripShips} ships have been sunk in the battle.");
            }
            else if (secondPlayerShips == 0)
            {
                Console.WriteLine($"Player One has won the game! " +
                    $"{ripShips} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! " +
                    $"Player One has {firstPlayerShips} ships left. " +
                    $"Player Two has {secondPlayerShips} ships left.");
            }

        }

        static bool IndexExists(int row, int col, char[,] matrix)
        {
            if (row >= matrix.GetLength(0) || row < 0 ||
                col >= matrix.GetLength(1) || col < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}