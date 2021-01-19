using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string numPattern = @"\d";
            string emojiPattern = @"((:{2})|(\*{2}))[A-Z][a-z]{2,}\1";

            Regex numReg = new Regex(numPattern);
            Regex emojiReg = new Regex(emojiPattern);

            string text = Console.ReadLine();

            MatchCollection nums = numReg.Matches(text);

            long coolThreshold = 1;
            numReg.Matches(text)
                .Select(n => n.Value)
                .Select(int.Parse)
                .ToList()
                .ForEach(x => coolThreshold *= x);

            List<string> allEmojis = new List<string>();
            List<string> coolEmojis = new List<string>();

            MatchCollection emojis = emojiReg.Matches(text);



            foreach (Match emoji in emojis)
            {
                long coolIndex = emoji.Value
                      .Substring(2, emoji.Value.Length - 4)
                      .ToCharArray()
                      .Sum(x => (int)x);

                if (coolIndex > coolThreshold)
                {
                    coolEmojis.Add(emoji.Value);
                    allEmojis.Add(emoji.Value);
                }
                else
                {
                    allEmojis.Add(emoji.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{allEmojis.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));
            
        }
    }
}
