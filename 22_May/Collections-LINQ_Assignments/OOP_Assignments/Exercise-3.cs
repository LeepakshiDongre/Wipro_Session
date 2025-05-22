using System;
using System.Collections.Generic;

interface IAttendance
{
    void MarkAttendance();
}

abstract class Staff
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public Staff(int id, string name, string department)
    {
        Id = id;
        Name = name;
        Department = department;
    }

    public abstract double CalculateSalary();
}

class FullTimeStaff : Staff, IAttendance
{
    public double MonthlySalary { get; set; }

    public FullTimeStaff(int id, string name, string department, double monthlySalary) 
        : base(id, name, department)
    {
        MonthlySalary = monthlySalary;
    }

    public override double CalculateSalary()
    {
        return MonthlySalary;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} marked attendance.");
    }
}

class PartTimeStaff : Staff, IAttendance
{
    public double HourlyWage { get; set; }
    public int HoursWorked { get; set; }

    public PartTimeStaff(int id, string name, string department, double hourlyWage, int hoursWorked) 
        : base(id, name, department)
    {
        HourlyWage = hourlyWage;
        HoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return HourlyWage * HoursWorked;
    }

    public void MarkAttendance()
    {
        Console.WriteLine($"{Name} marked attendance.");
    }
}

class Program
{
    static void Main()
    {
        List<Staff> staffList = new List<Staff>
        {
            new FullTimeStaff(1, "John", "IT", 3000),
            new PartTimeStaff(2, "Mary", "HR", 15, 80)
        };

        foreach (var staff in staffList)
        {
            Console.WriteLine($"Staff: {staff.Name}, Salary: ${staff.CalculateSalary()}");
            if (staff is IAttendance)
            {
                ((IAttendance)staff).MarkAttendance();
            }
        }
    }
}
