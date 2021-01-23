using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> cars = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                string[] forLoopCommand = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string model = forLoopCommand[0];
                int mileage = int.Parse(forLoopCommand[1]);
                int fuel = int.Parse(forLoopCommand[2]);

                cars.Add(model, new Dictionary<string, int>
                {
                    {"mileage", mileage },
                    {"fuel", fuel }
                });
            }

            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] tockens = command
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string car = tockens[1];
                string act = tockens[0];
                switch (act)
                {
                    case "Drive":
                        int distance = int.Parse(tockens[2]);
                        int fuelNeed = int.Parse(tockens[3]);
                        if (fuelNeed <= cars[car]["fuel"])
                        {
                            cars[car]["fuel"] -= fuelNeed;
                            cars[car]["mileage"] += distance;
                            Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeed} liters of fuel consumed.");
                            if (cars[car]["mileage"] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {car}!");
                                cars.Remove(car);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        break;

                    case "Refuel":
                        int fuelAdd = int.Parse(tockens[2]);
                        if (cars[car]["fuel"] + fuelAdd <= 75)
                        {
                            cars[car]["fuel"] += fuelAdd;
                            Console.WriteLine($"{car} refueled with {fuelAdd} liters");
                        }
                        else
                        {
                            int diff = 75 - cars[car]["fuel"];
                            cars[car]["fuel"] += diff;
                            Console.WriteLine($"{car} refueled with {diff} liters");
                        }
                        break;

                    case "Revert":
                        int km = int.Parse(tockens[2]);
                        if (cars[car]["mileage"] - km >= 10000)
                        {
                            cars[car]["mileage"] -= km;
                            Console.WriteLine($"{car} mileage decreased by {km} kilometers");
                        }
                        else
                        {
                            cars[car]["mileage"] = 10000;
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var car in cars.OrderByDescending(m => m.Value["mileage"])
                .ThenBy(n => n.Key))
            {
                int mileage = car.Value["mileage"];
                int fuel = car.Value["fuel"];
                Console.WriteLine($"{car.Key} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt.");
            }
        }
    }
}
