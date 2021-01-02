using System;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var min = int.MaxValue;

            while (input != "Stop")
            {
                var num = int.Parse(input);
                if (num < min)
                {
                    min = num;
                }
                input = Console.ReadLine();

            }

            Console.WriteLine(min);
        }
    }
}
