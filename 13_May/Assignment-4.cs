using System;

// Step 1: Create the abstract class Employee
abstract class Employee
{
    // Abstract method: CalculateSalary, to be implemented by derived classes
    public abstract void CalculateSalary();

    // Concrete method: ShowBasicInfo
    public void ShowBasicInfo()
    {
        Console.WriteLine("Employee details:");
    }
}

// Step 2a: Create derived class FullTimeEmployee
class FullTimeEmployee : Employee
{
    private double basicSalary = 5000;
    private double allowance = 2000;

    // Implement the abstract method CalculateSalary for FullTimeEmployee
    public override void CalculateSalary()
    {
        double totalSalary = basicSalary + allowance;
        Console.WriteLine($"Salary: {basicSalary} + {allowance} = {totalSalary}");
    }
}

// Step 2b: Create derived class PartTimeEmployee
class PartTimeEmployee : Employee
{
    private double hourlyRate = 20;
    private int hoursWorked = 30;

    // Implement the abstract method CalculateSalary for PartTimeEmployee
    public override void CalculateSalary()
    {
        double totalSalary = hourlyRate * hoursWorked;
        Console.WriteLine($"Salary: {hourlyRate} * {hoursWorked} = {totalSalary}");
    }
}

// Step 3: Main method to test the Employee hierarchy
class Program
{
    static void Main()
    {
        // Step 3a: Create objects using Employee reference
        Employee fullTimeEmp = new FullTimeEmployee();
        Employee partTimeEmp = new PartTimeEmployee();

        // Step 3b: Call ShowBasicInfo and CalculateSalary for both objects
        Console.WriteLine("FullTimeEmployee:");
        fullTimeEmp.ShowBasicInfo();
        fullTimeEmp.CalculateSalary();

        Console.WriteLine("\nPartTimeEmployee:");
        partTimeEmp.ShowBasicInfo();
        partTimeEmp.CalculateSalary();
    }
}
