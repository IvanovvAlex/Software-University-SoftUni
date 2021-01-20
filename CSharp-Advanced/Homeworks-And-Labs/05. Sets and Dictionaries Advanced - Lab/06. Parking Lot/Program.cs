using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string[] command = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "END")
            {
                string action = command[0];
                string car = command[1];

                switch (action)
                {
                    case "IN":
                        cars.Add(car);
                        break;
                    case "OUT":
                        cars.Remove(car);
                        break;
                }

                command = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
            if (cars.Count == 0)
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
