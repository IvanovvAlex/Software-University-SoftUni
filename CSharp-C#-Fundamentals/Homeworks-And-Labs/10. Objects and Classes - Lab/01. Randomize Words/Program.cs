using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < line.Length; i++)
            {
                int index = rnd.Next(0, line.Length);
                string currentWord = line[i];
                line[i] = line[index];
                line[index] = currentWord;
            }

            Console.WriteLine(string.Join(Environment.NewLine, line));
        }
    }
}
