using System;

namespace Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int other = int.Parse(Console.ReadLine());

            double dogprice = dogs * 2.50;
            double otherprice = other * 4;
            double all = dogprice + otherprice;
            Console.WriteLine("{0} lv.", all);
        }
    }
}
