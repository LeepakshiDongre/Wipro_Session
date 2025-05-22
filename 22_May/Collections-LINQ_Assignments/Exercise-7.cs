using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();

        Console.WriteLine("Even Numbers:");
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nOdd Numbers:");
        foreach (var number in oddNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
