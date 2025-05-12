using System;

// Define the interface
interface ICalculator
{
    int Add(int a, int b);
    int Subtract(int a, int b);
    int Multiply(int a, int b);
    int Divide(int a, int b);
}

// Implement the interface
class SimpleCalculator : ICalculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return a / b;
    }
}

// Program entry point
class Program
{
    static void Main()
    {
        ICalculator calc = new SimpleCalculator();

        // Perform calculations
        Console.WriteLine("Add: " + calc.Add(10, 5));           // Output: 15
        Console.WriteLine("Subtract: " + calc.Subtract(10, 5)); // Output: 5
        Console.WriteLine("Multiply: " + calc.Multiply(10, 5)); // Output: 50
        Console.WriteLine("Divide: " + calc.Divide(10, 5));     // Output: 2
    }
}
