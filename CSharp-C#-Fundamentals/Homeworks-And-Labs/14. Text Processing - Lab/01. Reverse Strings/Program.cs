using System;
using System.Text;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstCommand = Console.ReadLine();

            while (firstCommand != "end")
            {
                string line = firstCommand;
                StringBuilder reversed = new StringBuilder();

                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed.Append(line[i]);
                }
                string print = reversed.ToString();

                Console.WriteLine($"{line} = {print}");

                firstCommand = Console.ReadLine();
            }
        }
    }
}
