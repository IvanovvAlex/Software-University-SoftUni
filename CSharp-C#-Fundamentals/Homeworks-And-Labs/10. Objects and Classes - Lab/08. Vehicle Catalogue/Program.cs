using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] command = line
                    .Split("/", StringSplitOptions.RemoveEmptyEntries);

                string type = command[0];
                string brand = command[1];
                string model = command[2];
                int info = int.Parse(command[3]);
                if (type == "Car")
                {
                    catalog.Cars.Add(new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = info
                    });
                }
                if (type == "Truck")
                {
                    catalog.Trucks.Add(new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = info
                    });
                }

                line = Console.ReadLine();
            }
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (var car in catalog.Cars.OrderBy(n => n.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(n => n.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public List<Car> Cars { get; }
        public List<Truck> Trucks { get; }

        public Catalog() // инициализация на Cars и Trucks листовете в конструктора
        {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
        }
    }
}