using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel)
          : base(horsePower, fuel)
        {

        }

        private double defaultFuelConsumption = 3;

        public override double FuelConsumption
        {
            get { return defaultFuelConsumption; }
            set { FuelConsumption = defaultFuelConsumption; }
        }

        public override void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}
