using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] line = input
                .ToCharArray();

            StringBuilder digits = new StringBuilder();

            foreach (var symb in line)
            {
                if (Char.IsDigit(symb))
                {
                    digits.Append(symb);
                }
            }

            StringBuilder letters = new StringBuilder();

            foreach (var symb in line)
            {
                if (Char.IsLetter(symb))
                {
                    letters.Append(symb);
                }
            }

            StringBuilder symbols = new StringBuilder();

            foreach (var symb in line)
            {
                if (Char.IsLetter(symb) == false && Char.IsDigit(symb) == false)
                {
                    symbols.Append(symb);
                }
            }

            string printDigits = digits.ToString();
            string printLetters = letters.ToString();
            string printSymbols = symbols.ToString();

            Console.WriteLine(printDigits);
            Console.WriteLine(printLetters);
            Console.WriteLine(printSymbols);
        }
    }
}
