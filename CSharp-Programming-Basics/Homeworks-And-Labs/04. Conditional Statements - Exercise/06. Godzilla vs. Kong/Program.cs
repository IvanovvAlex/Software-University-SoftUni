using System;

namespace Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyHave = double.Parse(Console.ReadLine());
            double statisti = double.Parse(Console.ReadLine());
            double statistclothpr = double.Parse(Console.ReadLine());
            double sumcloth = statisti * statistclothpr;

            double decor = moneyHave * 0.10;
            if (statisti > 150)
            {
                sumcloth = sumcloth - (sumcloth * 0.10);
            }


            double all = decor + sumcloth;

            if (all <= moneyHave)
            {
                double n = moneyHave - all;
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left.", n);
            }
            else
            {
                double n = all - moneyHave;
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:f2} leva more.", n);
            }
        }
    }
}
