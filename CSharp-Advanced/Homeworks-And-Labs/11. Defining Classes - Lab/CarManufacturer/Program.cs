
namespace CarManufacturer
{
    namespace CarManufacturer
    {
        using System;
        using System.Collections.Generic;
        public class StartUp
        {
            static void Main(string[] args)
            {
                List<Tire[]> tires = new List<Tire[]>();
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                while (string.Join(" ", command) != "No more tires")
                {
                    int firstTireYear = int.Parse(command[0]);
                    double firstTirePressure = double.Parse(command[1]);
                    int secondTireYear = int.Parse(command[2]);
                    double secondTirePressure = double.Parse(command[3]);
                    int thirdTireYear = int.Parse(command[4]);
                    double thirdTirePressure = double.Parse(command[5]);
                    int fourthTireYear = int.Parse(command[6]);
                    double fourthTirePressure = double.Parse(command[7]);

                    tires.Add(new Tire[]
                    {
                    new Tire(firstTireYear, firstTirePressure),
                    new Tire(secondTireYear, secondTirePressure),
                    new Tire(thirdTireYear, thirdTirePressure),
                    new Tire(fourthTireYear, fourthTirePressure)
                    });

                    command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }
                List<Engine> engines = new List<Engine>();
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                while (string.Join(" ", command) != "Engines done")
                {
                    int horsePower = int.Parse(command[0]);
                    double cubicCapacity = double.Parse(command[1]);

                    engines.Add(new Engine(horsePower, cubicCapacity));

                    command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }
                List<Car> cars = new List<Car>();
                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                while (string.Join(" ", command) != "Show special")
                {
                    string make = command[0];
                    string model = command[1];
                    int year = int.Parse(command[2]);
                    double fuelQuantity = double.Parse(command[3]);
                    double fuelConsumption = double.Parse(command[4]);
                    Engine currentEngine = engines[int.Parse(command[5])];
                    Tire[] currentTire = tires[int.Parse(command[6])];


                    cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, currentEngine, currentTire));

                    command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                }
                for (int i = 0; i < cars.Count; i++)
                {
                    bool tiresPressure = cars[i].Sum(cars[i].Tires) >= 9 && cars[i].Sum(cars[i].Tires) <= 10;
                    if (cars[i].Year < 2017 || cars[i].Engine.HorsePower < 330 || tiresPressure == false)
                    {
                        cars.RemoveAt(i);
                        i--;
                    }
                }
                foreach (Car car in cars)
                {
                    car.FuelQuantity = car.FuelQuantity - (car.FuelConsumption / 5);
                }
                foreach (Car car in cars)
                {
                    Console.WriteLine($"Make: {car.Make}");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Year: {car.Year}");
                    Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                    Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
                }
            }
        }
        public class Car
        {
            private string make;
            private string model;
            private int year;
            private double fuelQuantity;
            private double fuelConsumption;
            private Engine engine;
            private Tire[] tires;

            public Car()
            {
                this.Make = "VW";
                this.Model = "Golf";
                this.Year = 2025;
                this.FuelQuantity = 200;
                this.FuelConsumption = 10;
            }

            public Car(string make, string model, int year) : this()
            {
                this.Make = make;
                this.Model = model;
                this.Year = year;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) : this(make, model, year)
            {
                this.FuelQuantity = fuelQuantity;
                this.FuelConsumption = fuelConsumption;
            }

            public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
                : this(make, model, year, fuelQuantity, fuelConsumption)
            {
                this.Engine = engine;
                this.Tires = tires;
            }
            public string Make
            {
                get { return this.make; }
                set { this.make = value; }
            }

            public string Model
            {
                get { return this.model; }
                set { this.model = value; }
            }

            public int Year
            {
                get { return this.year; }
                set { this.year = value; }
            }

            public double FuelQuantity
            {
                get { return this.fuelQuantity; }
                set { this.fuelQuantity = value; }
            }

            public double FuelConsumption
            {
                get { return this.fuelConsumption; }
                set { this.fuelConsumption = value; }
            }

            public Engine Engine
            {
                get { return this.engine; }
                set { this.engine = value; }
            }

            public Tire[] Tires
            {
                get { return this.tires; }
                set { this.tires = value; }
            }
            public double Sum(Tire[] tires)
            {
                double sum = 0;
                foreach (Tire tire in this.Tires)
                {
                    sum += tire.Pressure;
                }
                return sum;
            }
        }
        public class Engine
        {
            private int horsePower;
            private double cubicCapacity;

            public Engine(int horsePower, double cubicCapacity)
            {
                this.HorsePower = horsePower;
                this.CubicCapacity = cubicCapacity;
            }

            public int HorsePower
            {
                get { return this.horsePower; }
                set { this.horsePower = value; }
            }

            public double CubicCapacity
            {
                get { return this.cubicCapacity; }
                set { this.cubicCapacity = value; }
            }
        }
        public class Tire
        {
            private int year;
            private double pressure;

            public Tire(int year, double pressure)
            {
                this.Year = year;
                this.Pressure = pressure;
            }

            public int Year
            {
                get { return this.year; }
                set { this.year = value; }
            }

            public double Pressure
            {
                get { return this.pressure; }
                set { this.pressure = value; }
            }
        }
    }
}
