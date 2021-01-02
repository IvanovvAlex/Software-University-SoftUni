using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double counter1 = 0;
            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;
            double counter5 = 0;

            for (int i = 0; i < n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    counter1++;
                }
                if (200 <= num && num < 400)
                {
                    counter2++;
                }
                if (400 <= num && num < 600)
                {
                    counter3++;
                }
                if (600 <= num && num < 800)
                {
                    counter4++;
                }
                if (num >= 800)
                {
                    counter5++;
                }
            }

            double p1 = (counter1 / n) * 100;
            double p2 = (counter2 / n) * 100;
            double p3 = (counter3 / n) * 100;
            double p4 = (counter4 / n) * 100;
            double p5 = (counter5 / n) * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");

        }
    }
}
