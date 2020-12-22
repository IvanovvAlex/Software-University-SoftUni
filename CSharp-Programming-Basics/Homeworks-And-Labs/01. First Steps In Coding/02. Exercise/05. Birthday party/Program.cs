using System;

namespace Birthday_party
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double cakeprice = n - (n * 0.80);
            double drinkprice = cakeprice - (cakeprice * 0.45);
            double animatorprice = n / 3;
            double all = n + cakeprice + drinkprice + animatorprice;
            Console.WriteLine(all);
        }
    }
}
