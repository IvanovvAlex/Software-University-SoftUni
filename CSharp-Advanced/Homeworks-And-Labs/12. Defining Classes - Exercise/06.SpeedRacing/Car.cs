using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumptionPerKilometer;
        double travelledDistance;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model
            , double fuelAmount
            , double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public static void Drive(Car car, double amountOfKm)
        {
            car.FuelAmount -= (car.FuelConsumptionPerKilometer * amountOfKm);
            car.TravelledDistance += amountOfKm;
        }
        public static bool FuelCheck(double amountOfKm
            , double fuelAmount
            , double fuelConsumptionPerKilometer)
        {
            if (amountOfKm * fuelConsumptionPerKilometer <= fuelAmount)
            {
                return true;
            }
            return false;
        }
    }
}
