using System;
using System.Net.Sockets;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minMoney = double.Parse(Console.ReadLine());
            var trueOrFalse = true;
            double socialmoney = 0;
            double excellentmoney = 0;




            if (money < minMoney && grade > 4.5)
            {
                socialmoney = minMoney * 0.35;
                trueOrFalse = false;
            }
            if (grade >= 5.5)
            {
                excellentmoney = grade * 25;
                trueOrFalse = false;
            }

            if (socialmoney > excellentmoney)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialmoney)} BGN");
                trueOrFalse = false;
            }
            if (excellentmoney > socialmoney)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentmoney)} BGN");
                trueOrFalse = false;
            }
            if (trueOrFalse)
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }
        }
    }
}
