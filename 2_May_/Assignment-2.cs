using System;

class Program
{
    //Recursive function to find factorial
    static long Factorial(int n)
    {
        if (n == 0 || n == 1)
        return 1;
        else
        return n * Factorial(n - 1);
        
    }
    static void Main()
    {
        int[] numbers = {  1, 2, 3, 4, 5, 6, 7};
        foreach (int num in numbers)
        {
            Console.WriteLine($"Factorial of {num} = {Factorial (num)}");
        }
        
    }
}