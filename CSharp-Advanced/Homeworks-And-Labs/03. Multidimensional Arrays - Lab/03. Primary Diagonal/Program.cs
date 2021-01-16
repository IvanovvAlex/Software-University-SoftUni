using System;

namespace _03._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(line[col]);
                }
            }
            int sum = 0;
            for (int row = 0; row < n; row++)
            {
                sum += matrix[row, row];
            }
            Console.WriteLine(sum);
        }
    }
}
