using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> students = new List<string> { "Alice", "Bob", "Charlie", "David", "Eve" };
        
        // Display all names
        Console.WriteLine("Student Names:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        // Sort and display
        students.Sort();
        Console.WriteLine("\nSorted Student Names:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}
