using System;

namespace ConsoleApp2
{
    // Employee class with fields and methods
    internal class Employee
    {
        // Fields
        public int EmployeeID;
        public string Name;
        public string Department;
        public double Salary;

        // Method to print employee details
        public void PrintDetails()
        {
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {Department}");
            Console.WriteLine($"Salary: ${Salary}");
        }

        // Method to update employee salary
        public void UpdateSalary(double newSalary)
        {
            Salary = newSalary;
            Console.WriteLine($"Salary updated to: ${Salary}");
        }

        // Method to calculate the annual salary
        public double AnnualSalary()
        {
            return Salary * 12;
        }
    }

    // Program class to create and manipulate Employee objects
    class Program
    {
        static void Main()
        {
            // Create instances of the Employee class
            Employee emp1 = new Employee { EmployeeID = 101, Name = "John Doe", Department = "Finance", Salary = 5000 };
            Employee emp2 = new Employee { EmployeeID = 102, Name = "Jane Smith", Department = "HR", Salary = 4500 };

            // Print details of both employees
            emp1.PrintDetails();
            emp2.PrintDetails();

            // Update salary of emp1
            emp1.UpdateSalary(5500);

            // Print the annual salary of emp2
            double annualSalary = emp2.AnnualSalary();
            Console.WriteLine($"Annual Salary of {emp2.Name}: ${annualSalary}");
        }
    }
}
