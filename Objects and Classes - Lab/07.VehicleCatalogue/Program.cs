using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace _07.VehicleCatalogue
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = null;
            Catalog catalog = new Catalog();
            while ((input = Console.ReadLine()) != "end")
                {
                List<string> list = input
                    .Split("/")
                    .ToList();
                string tipe = list[0];
                string brand = list[1];
                string model = list[2];
                int value = int.Parse(list[3]);
                if (tipe == "Car")
                    {
                    Car car = new Car(brand, model, value);
                    catalog.Cars.Add(car);
                    }
                else
                    {
                    Truck truck = new Truck(brand, model, value);
                    catalog.Trucks.Add(truck);
                    }
                }
            if (catalog.Cars.Count > 0)
                {
                Console.WriteLine("Cars:");
                }

            foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
                {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            if (catalog.Trucks.Count > 0)
                {
                Console.WriteLine("Trucks:");
                }
            foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    public class Catalog
    {
        public Catalog()
            {
            Cars = new List<Car>();
            Trucks = new List<Truck>();
            }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        }
    public class Car
        {
        public Car(string brand, string model, int value)
            {
            Brand = brand;
            Model = model;
            HorsePower = value;
            }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        }
    public class Truck
        {
        public Truck(string brand, string model, int value)
            {
            Brand = brand;
            Model = model;
            Weight = value;
            }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
        }
    }
