using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string startResource = Console.ReadLine();
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (startResource != "stop")
            {
                string resource = startResource;
                int quantity = int.Parse(Console.ReadLine());

                if (result.ContainsKey(resource))
                {
                    result[resource] += quantity;
                }
                else
                {
                    result.Add(resource, quantity);
                }

                startResource = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
