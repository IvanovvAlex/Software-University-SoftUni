using System;

namespace _06._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArr = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);                
                jaggedArr[row] = new int[line.Length];
                for (int col = 0; col < line.Length; col++)
                {                    
                    jaggedArr[row][col] = int.Parse(line[col]);                   
                }
            }

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "END")
                {
                    break;
                }

                switch (command[0])
                {                    
                    case "Add":
                        try
                        {
                            int row = int.Parse(command[1]);
                            int col = int.Parse(command[2]);
                            int value = int.Parse(command[3]);
                            jaggedArr[row][col] += value;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid coordinates");
                            //throw;
                        }
                        break;
                    case "Subtract":
                        try
                        {
                            int row = int.Parse(command[1]);
                            int col = int.Parse(command[2]);
                            int value = int.Parse(command[3]);
                            jaggedArr[row][col] -= value;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid coordinates");
                            //throw;
                        }
                        break;                                        
                }
            }
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                for (int col = 0; col < jaggedArr[row].Length; col++)
                {
                    
                        Console.Write($"{jaggedArr[row][col]} ");                      
                }
                Console.WriteLine();
            }
        }
    }
}
