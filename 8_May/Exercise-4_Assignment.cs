using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a List<int> with 10 numbers (including duplicates)
        List<int> numbers = new List<int> { 4, 7, 2, 4, 9, 2, 1, 7, 6, 3 };

        // 2. Use HashSet to find unique numbers
        HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

        // 3. Print unique numbers
        Console.WriteLine("Unique numbers:");
        foreach (var num in uniqueNumbers)
        {
            Console.WriteLine(num);
        }

        // 4. Count of unique elements
        Console.WriteLine($"\nTotal unique elements: {uniqueNumbers.Count}");
    }
}
