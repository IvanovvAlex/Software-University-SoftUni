using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main()
        {
            char letter = char.Parse(Console.ReadLine());
            if (letter == 'A' || letter == 'B' || letter == 'C' || letter == 'D' || letter == 'E'
                || letter == 'F' || letter == 'G' || letter == 'H' || letter == 'I' || letter == 'J'
                || letter == 'K' || letter == 'L' || letter == 'M' || letter == 'N' || letter == 'O'
                || letter == 'P' || letter == 'Q' || letter == 'R' || letter == 'S' || letter == 'T'
                || letter == 'U' || letter == 'V' || letter == 'W' || letter == 'X' || letter == 'Y'
                || letter == 'Z')
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
