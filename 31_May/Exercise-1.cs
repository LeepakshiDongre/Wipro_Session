using System;
using System.Collections.Generic;

public interface IRentable
{
    void Rent();
}

public abstract class Vehicle
{
    public string Model { get; set; }
    public decimal DailyRent { get; set; }
}

public class Car : Vehicle, IRentable
{
    public void Rent() => Console.WriteLine($"Renting Car: {Model} at {DailyRent:C} per day.");
}

public class Bike : Vehicle, IRentable
{
    public void Rent() => Console.WriteLine($"Renting Bike: {Model} at {DailyRent:C} per day.");
}

public class Truck : Vehicle, IRentable
{
    public void Rent() => Console.WriteLine($"Renting Truck: {Model} at {DailyRent:C} per day.");
}

public class RentalService
{
    private List<IRentable> vehicles = new List<IRentable>();

    public void AddVehicle(IRentable vehicle) => vehicles.Add(vehicle);

    public void RentAll()
    {
        Console.WriteLine("Rented Vehicles:");
        foreach (var vehicle in vehicles)
            vehicle.Rent();
    }
}

// "Library" usage in main method
class Program
{
    static void Main()
    {
        var rentalService = new RentalService();

        // Creating vehicle objects
        var car = new Car { Model = "Toyota Camry", DailyRent = 60.00m };
        var bike = new Bike { Model = "Yamaha R15", DailyRent = 20.00m };
        var truck = new Truck { Model = "Ford F-150", DailyRent = 100.00m };

        // Adding vehicles to rental service
        rentalService.AddVehicle(car);
        rentalService.AddVehicle(bike);
        rentalService.AddVehicle(truck);

        // Display all rented vehicles and costs
        rentalService.RentAll();
    }
}
