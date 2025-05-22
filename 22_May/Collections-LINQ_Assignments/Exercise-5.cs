using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(string name, string department)
    {
        Name = name;
        Department = department;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Employee("Alice", "HR"),
            new Employee("Bob", "IT"),
            new Employee("Charlie", "HR"),
            new Employee("David", "Finance"),
            new Employee("Eve", "IT"),
            new Employee("Frank", "Finance")
        };

        var groupedByDepartment = employees.GroupBy(e => e.Department);

        foreach (var group in groupedByDepartment)
        {
            Console.WriteLine($"\nDepartment: {group.Key}");
            foreach (var employee in group)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
