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
            new Student("Eve", 70),
            new Student("Frank", 80)
        };

        var top3Students = students.OrderByDescending(s => s.Marks).Take(3).ToList();

        Console.WriteLine("Top 3 Students:");
        foreach (var student in top3Students)
        {
            Console.WriteLine($"{student.Name}: {student.Marks} marks");
        }
    }
}
