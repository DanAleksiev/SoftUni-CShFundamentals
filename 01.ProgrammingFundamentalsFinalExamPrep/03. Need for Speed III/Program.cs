using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Need_for_Speed_III
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n = int.Parse(Console.ReadLine());
            string input;
            Dictionary<string, string> cars = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
                {
                input = Console.ReadLine();
                List<string> carSplit = input.Split("|").ToList();
                string car = carSplit[0];
                int milege = int.Parse(carSplit[1]);
                int fuel = int.Parse(carSplit[2]);
                cars[car] = $"{milege}|{fuel}";

                }
            while ((input = Console.ReadLine()) != "Stop")
                {
                List<string> splitInput = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToList();
                string action = splitInput[0];
                string currentCar = splitInput[1];
                if (action == "Drive")
                    {
                    int distance = int.Parse(splitInput[2]);
                    int usedFuel = int.Parse(splitInput[3]);

                    List<int> milegeFuel = cars[currentCar].Split("|").Select(int.Parse).ToList();
                    int milege = milegeFuel[0];
                    int fuel = milegeFuel[1];                 
                    if (usedFuel >= fuel)
                        {
                        Console.WriteLine("Not enough fuel to make that ride");
                        }
                    else
                        {
                        milege += distance;
                        fuel -= usedFuel;
                        Console.WriteLine($"{currentCar} driven for {distance} kilometers. {usedFuel} liters of fuel consumed.");
                        }
                    cars[currentCar] = $"{milege}|{fuel}";
                    if (milege> 100000) 
                        {
                        Console.WriteLine($"Time to sell the {currentCar}!");
                        cars.Remove(currentCar);
                        }
                    }
                else if (action == "Refuel")
                    {
                    int fuelUp = int.Parse(splitInput[2]);
                    List<int> milegeFuel = cars[currentCar].Split("|").Select(int.Parse).ToList();
                    int milege = milegeFuel[0];
                    int fuel = milegeFuel[1];
                    fuel += fuelUp;
                    int leftoverFuel = 0;
                    if (fuel > 75)
                        {
                        leftoverFuel = fuel - 75;
                        fuelUp-= leftoverFuel;
                        fuel = 75;
                        }
                    cars[currentCar] = $"{milege}|{fuel}";
                    Console.WriteLine($"{currentCar} refueled with {fuelUp} liters");
                    }
                else if (action == "Revert")
                    {
                    int decreasMilege = int.Parse(splitInput[2]);
                    List<int> milegeFuel = cars[currentCar].Split("|").Select(int.Parse).ToList();
                    int milege = milegeFuel[0];
                    int fuel = milegeFuel[1];
                    
                    milege-= decreasMilege;
                    if (milege > 10000)
                        {                       
                        Console.WriteLine($"{currentCar} mileage decreased by {decreasMilege} kilometers");
                        }
                    else
                        {
                        milege = 10000;
                        }
                    cars[currentCar] = $"{milege}|{fuel}";
                    }
                }
            foreach(var car in cars)
                {
                string currentCar = car.Value;
                List<int> milegeFuel = currentCar.Split("|").Select(int.Parse).ToList();
                int milege = milegeFuel[0];
                int fuel = milegeFuel[1];
                Console.WriteLine($"{car.Key} -> Mileage: {milege} kms, Fuel in the tank: {fuel} lt.");
                }
            }
        }
    }

