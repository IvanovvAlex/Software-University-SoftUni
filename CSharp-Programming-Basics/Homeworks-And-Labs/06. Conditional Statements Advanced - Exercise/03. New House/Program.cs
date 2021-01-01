using System;
using System.Diagnostics.CodeAnalysis;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            double numFlowers = double.Parse(Console.ReadLine());
            double moneyhave = double.Parse(Console.ReadLine());
            double moneyneed = 0;
            switch (flowers)
            {
                case "Roses":
                    moneyneed = numFlowers * 5d;
                    if (numFlowers > 80d)
                    {
                        moneyneed += -(moneyneed * 0.10);
                    }
                    break;

                case "Dahlias":
                    moneyneed = numFlowers * 3.80d;
                    if (numFlowers > 90d)
                    {
                        moneyneed += -(moneyneed * 0.15);
                    }
                    break;

                case "Tulips":
                    moneyneed = numFlowers * 2.80;
                    if (numFlowers > 80d)
                    {
                        moneyneed += -(moneyneed * 0.15);
                    }
                    break;

                case "Narcissus":
                    moneyneed = numFlowers * 3d;
                    if (numFlowers < 120d)
                    {
                        moneyneed += +(moneyneed * 0.15);
                    }
                    break;

                case "Gladiolus":
                    moneyneed = numFlowers * 2.50;
                    if (numFlowers < 80d)
                    {
                        moneyneed += +(moneyneed * 0.20);
                    }
                    break;
            }
            if (moneyhave >= moneyneed)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowers} and {moneyhave - moneyneed:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {moneyneed - moneyhave:f2} leva more.");
            }

        }
    }
}
