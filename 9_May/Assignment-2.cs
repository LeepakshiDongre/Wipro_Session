using System;

namespace ConsoleApp2
{
    // Base class Vehicle
    class Vehicle
    {
        public string Make;
        public string Model;

        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public void DisplayVehicle()
        {
            Console.WriteLine($"Vehicle Make: {Make}");
            Console.WriteLine($"Vehicle Model: {Model}");
        }
    }

    // Derived class Car
    class Car : Vehicle
    {
        public string FuelType;

        public Car(string make, string model, string fuelType)
            : base(make, model)  // Calling base class constructor
        {
            FuelType = fuelType;
        }

        public void DisplayCar()
        {
            DisplayVehicle(); // Calling base class method
            Console.WriteLine($"Car Fuel Type: {FuelType}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Car object and setting values
            Car myCar = new Car("Toyota", "Corolla", "Petrol");

            // Displaying vehicle and car details
            Console.WriteLine("Vehicle Details:");
            myCar.DisplayVehicle();  // Displays vehicle details

            Console.WriteLine("\nCar Details:");
            myCar.DisplayCar();  // Displays complete car details
        }
    }
}
