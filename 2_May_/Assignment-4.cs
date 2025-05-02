using System;

class Program
{
    // Recursive function to calculate sum from 1 to n
    static int Sum(int n)
    {
        if (n == 0)
            return 0;
        return n + Sum(n - 1);
    }

    static void Main()
    {
        int n = 10;
        int result = Sum(n);
        Console.WriteLine("Sum of digits from 1 to " + n + " is: " + result);
    }
}
