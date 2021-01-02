using System;
using System.ComponentModel;
using System.Xml;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "Stop")
                {
                    break;
                }
                Console.WriteLine(word);
            }
        }
    }
}
