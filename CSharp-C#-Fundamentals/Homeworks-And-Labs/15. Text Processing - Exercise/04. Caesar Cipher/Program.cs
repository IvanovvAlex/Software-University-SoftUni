using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                letter += (char)3;
                result.Append(letter);
            }
            string print = result.ToString();
            Console.WriteLine(print);
        }
    }
}
