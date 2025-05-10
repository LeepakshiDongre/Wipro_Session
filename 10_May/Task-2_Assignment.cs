using System;

class PowerCalculator
{
    // Method to calculate power for two integers
    public int Power(int baseValue, int exponent)
    {
        return (int)Math.Pow(baseValue, exponent);
    }

    // Method to calculate power for two doubles (double base, double exponent)
    public double Power(double baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }

    // Method to calculate power for two doubles (double base, int exponent)
    public double Power(double baseValue, int exponent)
    {
        return Math.Pow(baseValue, exponent);
    }

    // Method to calculate power for two integers (int base, double exponent)
    public double Power(int baseValue, double exponent)
    {
        return Math.Pow(baseValue, exponent);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of PowerCalculator
        PowerCalculator calculator = new PowerCalculator();

        // Calculate and print the result for 2^3 (integer base and exponent)
        int result1 = calculator.Power(2, 3);
        Console.WriteLine($"2^3 = {result1}");

        // Calculate and print the result for 5.5^2 (double base and integer exponent)
        double result2 = calculator.Power(5.5, 2);
        Console.WriteLine($"5.5^2 = {result2}");

        // Calculate and print the result for 2^3 (double base and integer exponent)
        double result3 = calculator.Power(2.0, 3);
        Console.WriteLine($"2.0^3 = {result3}");

        // Calculate and print the result for 5.5^2.0 (double base and double exponent)
        double result4 = calculator.Power(5.5, 2.0);
        Console.WriteLine($"5.5^2.0 = {result4}");
    }
}
