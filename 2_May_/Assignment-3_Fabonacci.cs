using System;

class Program
{
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nFibonacci number at position " + n + " is " + Fibonacci(n));
    }
}
