using System;
using System.Text;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string firstString = line[0];
            string secondString = line[1];

            int result = Returned(firstString, secondString);

            Console.WriteLine(result);
        }

         static int Returned(string firstString, string secondString)
        {
            

            string first = firstString;
            string second = secondString;
            
            byte[] firstWord = Encoding.ASCII.GetBytes(first);
            byte[] secondWord = Encoding.ASCII.GetBytes(second);

            int lenght = Math.Max(firstWord.Length, secondWord.Length);
            int result = 0;

            for (int i = 0; i < lenght; i++)
            {
                try
                {
                   result += (firstWord[i] * secondWord[i]);
                }
                catch (Exception)
                {
                    try
                    {
                        result += firstWord[i];
                    }
                    catch (Exception)
                    {
                        result += secondWord[i];
                    }
                }
            }

            return result;
        }
    }
}
