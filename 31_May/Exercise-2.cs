using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { ID = 1, Name = "Alice", Department = "HR", Salary = 50000 },
            new Employee { ID = 2, Name = "Bob", Department = "IT", Salary = 60000 },
            new Employee { ID = 3, Name = "Charlie", Department = "IT", Salary = 70000 },
            new Employee { ID = 4, Name = "David", Department = "HR", Salary = 55000 },
            new Employee { ID = 5, Name = "Eve", Department = "Finance", Salary = 65000 }
        };

        // Filter employees by department "IT"
        var itEmployees = employees.Where(e => e.Department == "IT").ToList();
        Console.WriteLine("Employees in IT Department:");
        foreach (var emp in itEmployees)
        {
            Console.WriteLine($"{emp.Name} - Salary: {emp.Salary:C}");
        }

        Console.WriteLine();

        // Sort employees by salary descending
        var sortedBySalary = employees.OrderByDescending(e => e.Salary).ToList();
        Console.WriteLine("Employees sorted by salary (descending):");
        foreach (var emp in sortedBySalary)
        {
            Console.WriteLine($"{emp.Name} - {emp.Department} - Salary: {emp.Salary:C}");
        }

        Console.WriteLine();

        // Average salary per department
        var avgSalaryByDept = employees
            .GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) })
            .ToList();

        Console.WriteLine("Average Salary by Department:");
        foreach (var dept in avgSalaryByDept)
        {
            Console.WriteLine($"{dept.Department}: {dept.AverageSalary:C}");
        }
    }
}
