using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRem = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            int index = text.IndexOf(wordToRem);
            while (index != -1)
            {                
                text = text.Remove(index, wordToRem.Length);
                index = text.IndexOf(wordToRem);
            }
            Console.WriteLine(text);
        }
    }
}
