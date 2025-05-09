using System;

// Base class Shape
class Shape
{
    // Virtual method Draw
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class Circle
class Circle : Shape
{
    // Override the Draw method
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Demonstrating method overriding using a Shape reference holding a Circle object
        Shape shapeReference = new Circle();  // Shape reference holding a Circle object
        
        // Calls the overridden Draw method in the Circle class
        shapeReference.Draw();  // Output: Drawing a circle

        // Additional Demonstration: Create and call methods on individual objects
        Console.WriteLine("\nDemonstrating individual object behavior:");

        Shape myShape = new Shape();
        myShape.Draw();  // Output: Drawing a shape

        Circle myCircle = new Circle();
        myCircle.Draw();  // Output: Drawing a circle
    }
}
