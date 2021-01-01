using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            int seconds = num1 + num2 + num3;
            int minutes = 0;
            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }
            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}
