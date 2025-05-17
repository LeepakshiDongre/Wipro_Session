using System;


interface IMaintenance
{
    void Service();
    void Repair();
}
class CarMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Car is being Serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Car is being repaired");
    }
}
class BikeMaintenance : IMaintenance
{
    public void Service()
    {
        Console.WriteLine("Bike is being Serviced");
    }
    public void Repair()
    {
        Console.WriteLine("Bike is being repaired");
    }
}
class Program
{
    static void Main()
    {
        IMaintenance car = new CarMaintenance();
        IMaintenance bike = new BikeMaintenance();

        car.Service();
        car.Repair();

        bike.Service();
        bike.Repair();
    }
}
