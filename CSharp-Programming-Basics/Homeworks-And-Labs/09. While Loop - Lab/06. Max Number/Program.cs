using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var max = int.MinValue;

            while (input != "Stop")
            {
                var num = int.Parse(input);
                if (num > max)
                {
                    max = num;
                }
                input = Console.ReadLine();

            }

            Console.WriteLine(max);
        }
    }
}
