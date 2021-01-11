using System;
using System.Text;
using System.Linq;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string final = string.Empty;
            int start = 0;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];

                if (final.LastIndexOf(letter) != final.Length - 1 || start == 0)
                {
                    final += letter;
                    start++;
                }

            }
            Console.WriteLine(final);
        }
    }
}
