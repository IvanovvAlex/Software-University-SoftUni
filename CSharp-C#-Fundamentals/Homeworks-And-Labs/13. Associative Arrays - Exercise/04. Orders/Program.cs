using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstCommand = Console.ReadLine()
                .Split()
                .ToArray();

            Dictionary<string, List<decimal>> cart = new Dictionary<string, List<decimal>>();

            while (firstCommand[0] != "buy")
            {
                string[] command = firstCommand;

                string item = command[0];
                decimal price = decimal.Parse(command[1]);
                int quantity = int.Parse(command[2]);
                

                if (cart.ContainsKey(item))
                {
                    cart[item][0] = price;
                    cart[item][1] += quantity;                    
                }
                else
                {
                    cart.Add(item, new List<decimal>());
                    cart[item].Add(price);
                    cart[item].Add(quantity);                   
                }

                firstCommand = Console.ReadLine()
                .Split()
                .ToArray();
            }
           
            foreach (var item in cart)
            {
                Console.WriteLine($"{item.Key} -> {item.Value[0]*item.Value[1]:f2}");
            }
        }
    }
}
