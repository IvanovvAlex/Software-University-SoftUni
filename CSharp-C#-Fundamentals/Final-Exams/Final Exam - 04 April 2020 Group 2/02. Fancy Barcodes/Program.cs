using System;
using System.Text.RegularExpressions;

namespace _02._Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string validBarcPattern = @"@\#+[A-Z][A-Za-z0-9]{4,}[A-Z]@\#+";
            string groupPattern = @"[0-9]";

            Regex validReg = new Regex(validBarcPattern);
            Regex groupReg = new Regex(groupPattern);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                MatchCollection valid = validReg.Matches(input);
                if (valid.Count == 1)
                {
                    MatchCollection group = groupReg.Matches(input);
                    if (group.Count == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", group)}");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
