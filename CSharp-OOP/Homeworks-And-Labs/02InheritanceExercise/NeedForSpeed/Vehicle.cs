using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        private double defaultFuelConsumption = 1.25;

        public double Fuel { get; set; }
        public int HorsePower { get; set; }        
        public virtual double FuelConsumption
        {
            get { return defaultFuelConsumption; } 
            set { FuelConsumption = defaultFuelConsumption; }
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}
