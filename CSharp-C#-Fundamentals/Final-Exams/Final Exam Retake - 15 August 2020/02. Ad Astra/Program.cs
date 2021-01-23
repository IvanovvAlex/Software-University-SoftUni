using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])(?<name>[A-Za-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<kcal>\d{1,5})\1";
            Regex reg = new Regex(pattern);

            string input = Console.ReadLine();
            MatchCollection matches = reg.Matches(input);

            int totalKcal = 0;

            foreach (Match match in matches)
            {
                totalKcal += int.Parse(match.Groups["kcal"].Value);
            }

            int days = (totalKcal / 2000);

            Console.WriteLine($"You have food to last you for: {days} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["kcal"].Value}");
            }
        }
    }
}
