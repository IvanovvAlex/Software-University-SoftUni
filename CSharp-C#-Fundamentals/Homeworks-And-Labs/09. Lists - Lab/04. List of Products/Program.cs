using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> shopList = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                shopList.Add(product);
            }

            shopList.Sort();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i}.{shopList[i-1]}");
            } 
        }
    }
}
