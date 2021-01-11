using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\", StringSplitOptions.RemoveEmptyEntries);

            int lastIndex = input.Length - 1;

            string[] result = input[lastIndex]
                .Split(".", StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"File name: {result[0]}");
            Console.WriteLine($"File extension: {result[1]}");
        }
    }
}
