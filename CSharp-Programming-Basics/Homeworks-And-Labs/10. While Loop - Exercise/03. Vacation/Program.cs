using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForExcurtion = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());

            string action = string.Empty;
            double moneyForAction = 0;
            int days = 0;
            int daysSpent = 0;
            string result = string.Empty;


            while (true)
            {
                action = Console.ReadLine();
                moneyForAction = double.Parse(Console.ReadLine());
                days++;

                if (action == "save")
                {
                    daysSpent = 0;
                    availableMoney += moneyForAction;
                    if (availableMoney >= moneyForExcurtion)
                    {
                        result = $"You saved the money for {days} days.";
                        break;
                    }
                }

                if (action == "spend")
                {
                    availableMoney -= moneyForAction;

                    if (availableMoney < 0)
                    {
                        availableMoney = 0;
                    }

                    daysSpent++;
                    if (daysSpent == 5)
                    {
                        result = "You can't save the money." + Environment.NewLine + $"{days}";
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
