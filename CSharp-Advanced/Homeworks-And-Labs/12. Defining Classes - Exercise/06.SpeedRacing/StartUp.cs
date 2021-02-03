using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Car> list = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = line[0];
                double fuelAmount = double.Parse(line[1]);
                double fuelConsumptionFor1km = double.Parse(line[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionFor1km);
                list.Add(model, car);
            }

            string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (string.Join(" ", input) != "End")
            {
                string carModel = input[1];
                double amountOfKm = double.Parse(input[2]);
                double fuelAmount = list[carModel].FuelAmount;
                double fuelConsumptionFor1km = list[carModel].FuelConsumptionPerKilometer;
                if (Car.FuelCheck(amountOfKm, fuelAmount, fuelConsumptionFor1km))
                {
                    Car.Drive(list[carModel], amountOfKm);
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (var car in list)
            {
                string model = car.Value.Model;
                double fuelAmount = car.Value.FuelAmount;
                double distanceTraveled = car.Value.TravelledDistance;
                Console.WriteLine($"{model} {fuelAmount:f2} {distanceTraveled}");
            }
        }
    }
}
