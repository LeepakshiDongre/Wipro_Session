using System;

public class Calculator
{
    // Add methods
    public static int Add(int a, int b) => a + b;
    public static float Add(float a, float b) => a + b;
    public static double Add(double a, double b) => a + b;

    // Subtract methods
    public static int Subtract(int a, int b) => a - b;
    public static float Subtract(float a, float b) => a - b;
    public static double Subtract(double a, double b) => a - b;

    // Multiply methods
    public static int Multiply(int a, int b) => a * b;
    public static float Multiply(float a, float b) => a * b;
    public static double Multiply(double a, double b) => a * b;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculator with Method Overloading\n");

        Console.WriteLine("Enter first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter second number:");
        string input2 = Console.ReadLine();

        Console.WriteLine("Choose operation: Add, Subtract, Multiply");
        string operation = Console.ReadLine().ToLower();

        // Determine datatype and parse inputs
        if (int.TryParse(input1, out int int1) && int.TryParse(input2, out int int2))
        {
            // Both inputs are int
            PerformOperation(int1, int2, operation);
        }
        else if (float.TryParse(input1, out float float1) && float.TryParse(input2, out float float2))
        {
            // Both inputs are float
            PerformOperation(float1, float2, operation);
        }
        else if (double.TryParse(input1, out double double1) && double.TryParse(input2, out double double2))
        {
            // Both inputs are double
            PerformOperation(double1, double2, operation);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter valid numbers.");
        }
    }

    // Overloaded methods to call Calculator based on datatype
    static void PerformOperation(int a, int b, string op)
    {
        int result = op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Subtract(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new InvalidOperationException("Unknown operation")
        };
        Console.WriteLine($"Result (int): {result}");
    }

    static void PerformOperation(float a, float b, string op)
    {
        float result = op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Subtract(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new InvalidOperationException("Unknown operation")
        };
        Console.WriteLine($"Result (float): {result}");
    }

    static void PerformOperation(double a, double b, string op)
    {
        double result = op switch
        {
            "add" => Calculator.Add(a, b),
            "subtract" => Calculator.Subtract(a, b),
            "multiply" => Calculator.Multiply(a, b),
            _ => throw new InvalidOperationException("Unknown operation")
        };
        Console.WriteLine($"Result (double): {result}");
    }
}
