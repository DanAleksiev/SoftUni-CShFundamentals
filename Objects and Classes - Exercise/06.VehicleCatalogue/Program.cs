using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace _06.VehicleCatalogue
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            List<Vehicle> vehicles = new List<Vehicle>();
            InportOfVehicles(vehicles);
            InterestIn(vehicles);
            AvarageHorsepower(vehicles);
            }
        static void InportOfVehicles(List<Vehicle> vehicles)
            {
            string input = null;
            while ((input = Console.ReadLine()) != "End")
                {
                List<string> vehicle = input
                    .Split()
                    .ToList();
                string typeOfVehicle = vehicle[0];
                if (typeOfVehicle == "car")
                    {
                    typeOfVehicle = "Car";
                    }
                else if (typeOfVehicle == "truck")
                    {
                    typeOfVehicle = "Truck";
                    }
                string model = vehicle[1];
                string color = vehicle[2];
                int horsePower = int.Parse(vehicle[3]);

                Vehicle currentVehicle = new Vehicle(typeOfVehicle, model, color, horsePower);
                vehicles.Add(currentVehicle);
                }
            }
        static void InterestIn(List<Vehicle> vehicles)
            {
            string input = null;
            while ((input = Console.ReadLine()) != "Close the Catalogue")
                {
                foreach (Vehicle currentVehcle in vehicles.Where(x => x.Model == input))
                    {
                    Console.WriteLine($"Type: {currentVehcle.TypeOfVehicle}");
                    Console.WriteLine($"Model: {currentVehcle.Model}");
                    Console.WriteLine($"Color: {currentVehcle.Color}");
                    Console.WriteLine($"Horsepower: {currentVehcle.HorsePower}");
                    }
                }
            }
        static void AvarageHorsepower(List<Vehicle> vehicles)
            {
            List<Vehicle> cars = vehicles.Where((x => x.TypeOfVehicle == "Car")).ToList();
            List<Vehicle> trucks = vehicles.Where((x => x.TypeOfVehicle == "Truck")).ToList();
            double totalCarHp = 0;
            foreach (Vehicle car in cars)
                {
                totalCarHp += car.HorsePower;
                }
            double avarageHpCars = totalCarHp / cars.Count;


            double totalTruckHp = 0;
            foreach (Vehicle truck in trucks)
                {
                totalTruckHp += truck.HorsePower;
                }
            double avarageHpTrucks = totalTruckHp / trucks.Count;
            if (cars.Count == 0)
                {
                avarageHpCars = 0;
                }
            if (trucks.Count == 0)
                {
                avarageHpTrucks = 0;
                }
            Console.WriteLine($"Cars have average horsepower of: {avarageHpCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageHpTrucks:f2}.");
            }
        class Vehicle
            {
            public Vehicle(string typeOfVehicle, string model, string color, int horsePower)
                {
                TypeOfVehicle = typeOfVehicle;
                Model = model;
                Color = color;
                HorsePower = horsePower;
                }
            public string TypeOfVehicle { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
            }
        }
    }
