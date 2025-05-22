using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5, 6, 7, 7 };

        var duplicateNumbers = numbers.GroupBy(n => n)
            .Where(g => g.Count() > 1)
            .Select(g => g.Key)
            .ToList();

        Console.WriteLine("Duplicate Numbers:");
        foreach (var number in duplicateNumbers)
        {
            Console.WriteLine(number);
        }
    }
}
