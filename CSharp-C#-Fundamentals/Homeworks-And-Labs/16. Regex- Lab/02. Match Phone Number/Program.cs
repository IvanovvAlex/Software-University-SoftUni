using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[+][3][5][9](?<delimiter>(?: )|(?:-))[2]\1[0-9]{3}\1[0-9]{4}\b";

            string numbers = Console.ReadLine();

            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(numbers);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}
