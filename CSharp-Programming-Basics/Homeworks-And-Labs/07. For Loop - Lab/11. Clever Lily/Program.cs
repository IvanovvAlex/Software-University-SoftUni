using System;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            double washmashinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());

            double toysSaleMoney = 0;
            int counterMoney = 0;
            double moneyGet = 10;
            double moneyHave = 0;

            for (int i = 1; i <= years; i += 2)
            {
                toysSaleMoney += toysPrice;
            }

            for (int i = 2; i <= years; i += 2)
            {
                moneyHave += +moneyGet;
                moneyGet += +10d;
                counterMoney++;
            }
            moneyHave += +toysSaleMoney;
            moneyHave += -counterMoney;

            if (moneyHave >= washmashinePrice)
            {
                Console.WriteLine($"Yes! {moneyHave - washmashinePrice:f2}");
            }
            if (moneyHave < washmashinePrice)
            {
                Console.WriteLine($"No! {washmashinePrice - moneyHave:f2}");
            }
        }
    }
}
