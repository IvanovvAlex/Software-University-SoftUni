using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                char latter = word[i];
                Console.WriteLine(latter);
            }
        }
    }
}
