using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            string modifiedText = ModifyText(text, repeats);
            Console.WriteLine(modifiedText);
        }

         static string ModifyText(string text, int repeats)
        {
            StringBuilder textForReturn = new StringBuilder();
            for (int i = 0; i < repeats; i++)
            {
                textForReturn.Append(text);
            }
            return textForReturn.ToString();
        }
    }
}
