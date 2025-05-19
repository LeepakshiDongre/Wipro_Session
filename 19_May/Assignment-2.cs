using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
}
class Program
{
    static void  Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee{EmployeeId = 1, Name = "Alice", Salary = 40000 },
            new Employee{EmployeeId = 2, Name = "Bob", Salary = 55000 },
            new Employee{EmployeeId = 3, Name = "Charlie", Salary = 60000 },
            new Employee{EmployeeId = 4, Name = "Diana", Salary = 47000 },
            new Employee{EmployeeId = 5, Name = "Ethan", Salary = 52000 },
        };

        var highestSalaryEmployee = employees.OrderByDescending(e => e.Salary).First();
        Console.WriteLine($"Employee with highest salary: {highestSalaryEmployee.Name} - {highestSalaryEmployee.Salary}");

        Dictionary<int, string> employeeDict = new Dictionary<int, string>();
        foreach (var employee in employees)
        {
            employeeDict[employee.EmployeeId] = employee.Name;


        }
        Console.WriteLine("\nEmployee Dictionary:");
        foreach (var pair in employeeDict)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");

        }
        Console.WriteLine("\nEnter Employee ID to search: ");
        int searchId = int.Parse(Console.ReadLine());

        if (employeeDict.TryGetValue(searchId, out string name))
        {
            Console.WriteLine($"Employee found: {name}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
    }
}