using System;
using System.IO;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeArea = weight * lenght;
            int pieces = 0;
            var end = true;
            string word = Console.ReadLine();

            while (word != "STOP")
            {
                int num = int.Parse(word);
                pieces += num;
                if (pieces >= cakeArea)
                {
                    Console.WriteLine($"No more cake left! You need {pieces - cakeArea} pieces more.");
                    end = false;
                    break;
                }
                word = Console.ReadLine();
            }
            if (end)
            {
                Console.WriteLine($"{cakeArea - pieces} pieces are left.");
            }

        }
    }
}
