using System;

// Base class Shape
class Shape
{
    // Virtual method Area (This will be overridden in derived classes)
    public virtual void Area()
    {
        Console.WriteLine("Area of the shape");
    }
}

// Derived class Rectangle
class Rectangle : Shape
{
    private double length;
    private double breadth;

    // Constructor for Rectangle
    public Rectangle(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    // Overloaded Area method for Rectangle
    public override void Area()
    {
        double area = length * breadth;
        Console.WriteLine($"Area of Rectangle: {area}");
    }
}

// Derived class Circle
class Circle : Shape
{
    private double radius;

    // Constructor for Circle
    public Circle(double radius)
    {
        this.radius = radius;
    }

    // Overloaded Area method for Circle
    public override void Area()
    {
        double area = Math.PI * Math.Pow(radius, 2);  // πr²
        Console.WriteLine($"Area of Circle: {area}");
    }
}

// Derived class Triangle
class Triangle : Shape
{
    private double baseLength;
    private double height;

    // Constructor for Triangle
    public Triangle(double baseLength, double height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }

    // Overloaded Area method for Triangle
    public override void Area()
    {
        double area = 0.5 * baseLength * height;  // 1/2 * base * height
        Console.WriteLine($"Area of Triangle: {area}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create instances of Rectangle, Circle, and Triangle
        Shape rectangle = new Rectangle(5, 3); // Rectangle with length 5 and breadth 3
        Shape circle = new Circle(4);           // Circle with radius 4
        Shape triangle = new Triangle(6, 4);    // Triangle with base 6 and height 4

        // Call the Area method for all shapes
        rectangle.Area();  // Output: Area of Rectangle: 15
        circle.Area();     // Output: Area of Circle: 50.26548245743669
        triangle.Area();   // Output: Area of Triangle: 12
    }
}
