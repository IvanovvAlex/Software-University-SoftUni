using System;

namespace _02Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];


            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < n; row++)
            {
                char[] line = Console.ReadLine()
                    .ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = line[col];
                    if (line[col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            int pollinatedFlowers = 0;
            string act = Console.ReadLine();
            while (act != "End")
            {
                switch (act)
                {
                    case "up":
                        matrix[beeRow, beeCol] = '.';
                        beeRow--;                       
                        if (beeRow > n-1 || beeRow < 0 || beeCol > n-1 || beeCol < 0)
                        {
                            Console.WriteLine("The bee got lost!");
                            if (pollinatedFlowers >= 5)
                            {
                                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-pollinatedFlowers} flowers more");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            return;
                        }
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeRow--;
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                        break;
                    case "down":
                        matrix[beeRow, beeCol] = '.';
                        beeRow++;                       
                        if (beeRow > n - 1 || beeRow < 0 || beeCol > n - 1 || beeCol < 0)
                        {
                            Console.WriteLine("The bee got lost!");
                            if (pollinatedFlowers >= 5)
                            {
                                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            return;
                        }
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeRow++;
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                        break;
                    case "left":
                        matrix[beeRow, beeCol] = '.';
                        beeCol--;                       
                        if (beeRow > n - 1 || beeRow < 0 || beeCol > n - 1 || beeCol < 0)
                        {
                            Console.WriteLine("The bee got lost!");
                            if (pollinatedFlowers >= 5)
                            {
                                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            return;
                        }
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeCol--;
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                        break;
                    case "right":
                        matrix[beeRow, beeCol] = '.';
                        beeCol++;
                        if (beeRow > n - 1 || beeRow < 0 || beeCol > n - 1 || beeCol < 0)
                        {
                            Console.WriteLine("The bee got lost!");
                            if (pollinatedFlowers >= 5)
                            {
                                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            else
                            {
                                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
                                for (int row = 0; row < n; row++)
                                {
                                    for (int col = 0; col < n; col++)
                                    {
                                        Console.Write(matrix[row, col]);
                                    }
                                    Console.WriteLine();
                                }
                            }
                            return;
                        }
                        if (matrix[beeRow, beeCol] == 'f')
                        {
                            pollinatedFlowers++;
                        }
                        else if (matrix[beeRow, beeCol] == 'O')
                        {
                            matrix[beeRow, beeCol] = '.';
                            beeCol++;
                            if (matrix[beeRow, beeCol] == 'f')
                            {
                                pollinatedFlowers++;
                            }
                        }
                        matrix[beeRow, beeCol] = 'B';
                        break;
                }
                act = Console.ReadLine();
            }
            if (pollinatedFlowers >= 5)
            {

                Console.WriteLine($"Great job, the bee managed to pollinate {pollinatedFlowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - pollinatedFlowers} flowers more");
            }
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
