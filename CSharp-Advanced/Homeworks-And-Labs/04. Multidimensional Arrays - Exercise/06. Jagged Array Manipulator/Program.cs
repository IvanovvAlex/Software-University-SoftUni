using System;

namespace _06._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] jaggedArr = new double[n][];

            for (int row = 0; row < n; row++)
            {
                string[] line = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                jaggedArr[row] = new double[line.Length];

                for (int col = 0; col < line.Length; col++)
                {                   
                    jaggedArr[row][col] = double.Parse(line[col]);
                }
            }

            for (int row = 0; row < n-1; row++)
            {
                if (jaggedArr[row].Length == jaggedArr[row+1].Length)
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] *= 2;
                        jaggedArr[row+1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        jaggedArr[row][col] /= 2;                        
                    }
                    for (int col = 0; col < jaggedArr[row+1].Length; col++)
                    {
                        jaggedArr[row + 1][col] /= 2;
                    }
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "End")
                {
                    break;
                }

                string action = command[0];

                switch (action)
                {
                    case "Add":
                        try
                        {
                            int row = int.Parse(command[1]);
                            int col = int.Parse(command[2]);
                            double value = double.Parse(command[3]);

                            jaggedArr[row][col] += value;
                        }
                        catch (Exception)
                        {
                        }
                        break;
                    case "Subtract":
                        try
                        {
                            int row = int.Parse(command[1]);
                            int col = int.Parse(command[2]);
                            double value = double.Parse(command[3]);

                            jaggedArr[row][col] -= value;
                        }
                        catch (Exception)
                        {
                        }
                        break;
                }
            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    Console.Write(jaggedArr[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
