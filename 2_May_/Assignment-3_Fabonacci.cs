using System;

class Program
{
    // Recursive function to get the nth Fibonacci number
    static int Fibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(Fibonacci(i) + " ");
        }
    }
}
