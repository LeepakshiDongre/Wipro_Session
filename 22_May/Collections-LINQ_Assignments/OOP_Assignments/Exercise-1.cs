using System;
using System.Collections.Generic;

abstract class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }
    public double RatePerDay { get; set; }

    public Vehicle(string vehicleNumber, string brand, double ratePerDay)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
        RatePerDay = ratePerDay;
    }

    public virtual double CalculateRent(int days)
    {
        return RatePerDay * days;
    }
}

class Car : Vehicle
{
    public Car(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }

    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days) + 20; // Surcharge for Car
    }
}

class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }

    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days); // No surcharge for Bike
    }
}

class Truck : Vehicle
{
    public Truck(string vehicleNumber, string brand, double ratePerDay) : base(vehicleNumber, brand, ratePerDay) { }

    public override double CalculateRent(int days)
    {
        return base.CalculateRent(days) + 50; // Surcharge for Truck
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("C123", "Toyota", 100),
            new Bike("B456", "Honda", 50),
            new Truck("T789", "Ford", 150)
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine($"Vehicle: {vehicle.Brand} - Rent for 5 days: ${vehicle.CalculateRent(5)}");
        }
    }
}
