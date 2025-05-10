using System;

// Base class Appliance
class Appliance
{
    // Virtual method Operate
    public virtual void Operate()
    {
        Console.WriteLine("Operating the appliance");
    }
}

// Derived class WashingMachine
class WashingMachine : Appliance
{
    // Override the Operate method
    public override void Operate()
    {
        Console.WriteLine("Washing clothes");
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Testing the Appliance base class method
        Appliance appliance = new Appliance();
        appliance.Operate();  // Output: Operating the appliance

        // Testing the WashingMachine derived class method
        WashingMachine washingMachine = new WashingMachine();
        washingMachine.Operate();  // Output: Washing clothes

        // Demonstrating polymorphism by using a base class reference for a derived class object
        Appliance applianceRef = new WashingMachine();  // Base class reference holding a WashingMachine object
        applianceRef.Operate();  // Output: Washing clothes (calls the overridden method in WashingMachine)
    }
}
