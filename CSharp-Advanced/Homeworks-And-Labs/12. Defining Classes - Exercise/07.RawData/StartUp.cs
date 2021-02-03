using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = line[0];
                int engineSpeed = int.Parse(line[1]);
                int enginePower = int.Parse(line[2]);
                int cargoWeight = int.Parse(line[3]);
                string cargoType = line[4];
                double tire1Pressure = double.Parse(line[5]);
                int tire1Age = int.Parse(line[6]);
                double tire2Pressure = double.Parse(line[7]);
                int tire2Age = int.Parse(line[8]);
                double tire3Pressure = double.Parse(line[9]);
                int tire3Age = int.Parse(line[10]);
                double tire4Pressure = double.Parse(line[11]);
                int tire4Age = int.Parse(line[12]);

                Tire[] tires = new Tire[4] 
                { new Tire(tire1Pressure, tire1Age),
                  new Tire(tire2Pressure, tire2Age),
                  new Tire(tire3Pressure, tire3Age),
                  new Tire(tire4Pressure, tire4Age)
                };
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                cars.Add(new Car(model, engine, cargo, tires));
            }
            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    foreach (var car in cars.Where(x => x.Tires.Any(t => t.Pressure < 1)
                    && x.Cargo.Type == "fragile"))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
                case "flamable":
                    foreach (var car in cars.Where(x => x.Engine.Power > 250 
                    && x.Cargo.Type == "flamable"))
                    {
                        Console.WriteLine(car.Model);
                    }
                    break;
            }
        }
    }
}
