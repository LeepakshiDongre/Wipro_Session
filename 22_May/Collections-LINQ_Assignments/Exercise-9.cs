using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Marks { get; set; }

    public Student(string name, int marks)
    {
        Name = name;
        Marks = marks;
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Alice", 90),
            new Student("Bob", 75),
            new Student("Charlie", 95),
            new Student("David", 85),
            new Student("Eve", 70)
        };

        double averageMarks = students.Average(s => s.Marks);
        var aboveAverageStudents = students.Count(s => s.Marks > averageMarks);

        Console.WriteLine($"Number of students above average: {aboveAverageStudents}");
    }
}
