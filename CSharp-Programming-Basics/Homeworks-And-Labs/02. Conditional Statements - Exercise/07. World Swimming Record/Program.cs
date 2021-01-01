using System;
using System.Threading;

namespace World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double rec = double.Parse(Console.ReadLine());
            double sec = double.Parse(Console.ReadLine());
            double secfor1m = double.Parse(Console.ReadLine());

            double firstcalc = sec * secfor1m;
            double secondcalc = Math.Floor(sec / 15);
            double third = secondcalc * 12.5;
            double all = firstcalc + third;

            if (all >= rec)
            {
                Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", all - rec);
            }
            else
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", all);
            }

        }
    }
}
