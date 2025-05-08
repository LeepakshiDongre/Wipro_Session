using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create a list of employee names
        List<string> employees = new List<string>();

        // 2. Add 5 employees
        employees.Add("Alice");
        employees.Add("Bob");
        employees.Add("Charlie");
        employees.Add("Diana");
        employees.Add("Edward");

        // 3. Remove an employee by name
        employees.Remove("Charlie");  // Removes "Charlie" from the list

        // 4. Check if a specific name exists
        string nameToCheck = "Bob";
        if (employees.Contains(nameToCheck))
        {
            Console.WriteLine($"{nameToCheck} is in the employee list.");
        }
        else
        {
            Console.WriteLine($"{nameToCheck} is NOT in the employee list.");
        }

        // 5. Print the total number of employees
        Console.WriteLine($"Total number of employees: {employees.Count}");

        // (Optional) Print all remaining employees
        Console.WriteLine("Current employees:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}