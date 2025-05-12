abstract class Shape
{
    public abstract void Draw();   //Abstract method
    public void Display()
    {
        Console.WriteLine("This is a shape");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}
class Program
{
    static void Main()
    {
        Circle circle = new Circle();
        circle.Draw();
    }
}





using System;

//Abstract class
abstract class Vehicle
{
    public string Brand;
    public string Year;

    // Concrete method
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Year: {Year}");
    }

    //Abstract method
    public abstract void Start();

}

//Derived class: Cae
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Car is staring with the key.");

    }
}

//Derived class : Bike
class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike is starting with the kick.");
    }
}