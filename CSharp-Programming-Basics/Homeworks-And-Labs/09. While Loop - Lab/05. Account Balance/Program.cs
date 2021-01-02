using System;

namespace Account_Balance
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if (amount <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {balance:F2}");
                    break;
                }

                if (input != "NoMoreMoney")
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                    input = Console.ReadLine();
                }
                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {balance:F2}");
                }
            }
        }
    }
}
