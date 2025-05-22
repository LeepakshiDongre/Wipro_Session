using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, decimal> salaryLookup = new Dictionary<int, decimal>
        {
            { 101, 50000 },
            { 102, 60000 },
            { 103, 55000 },
            { 104, 70000 },
            { 105, 65000 }
        };

        Console.Write("Enter Employee ID: ");
        int id = int.Parse(Console.ReadLine());

        if (salaryLookup.ContainsKey(id))
        {
            Console.WriteLine($"Employee {id}'s Salary: ${salaryLookup[id]}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}
