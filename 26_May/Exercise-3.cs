using System;

delegate double Operation(double a, double b);

class Calculator
{
    public static double Add(double a, double b) => a + b;
    public static double Subtract(double a, double b) => a - b;
    public static double Multiply(double a, double b) => a * b;
    public static double Divide(double a, double b) => b!= 0 ? a/b : 0;

}

class Program
{
    static void Main()
    {
        Operation op;

        op = Calculator.Add;
        Console.WriteLine("Add: " + op(10, 5));

        op = Calculator.Subtract;
        Console.WriteLine("Subtract: " + op(10, 5));

        op = Calculator.Multiply;
        Console.WriteLine("Multiply: " + op(10, 5));

        op = Calculator.Divide;
        Console.WriteLine("Divide: " + op(10, 5));
    }
}