using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    // Dictionary of subject -> marks
    public Dictionary<string, int> Marks { get; set; } = new Dictionary<string, int>();
}

class Program
{
    static void Main()
    {
        // Sample data: You can replace this with user input if needed
        var students = new List<Student>
        {
            new Student { Name = "Alice", Marks = new Dictionary<string, int> { { "Math", 85 }, { "Science", 90 }, { "English", 78 } } },
            new Student { Name = "Bob", Marks = new Dictionary<string, int> { { "Math", 92 }, { "Science", 88 }, { "English", 84 } } },
            new Student { Name = "Charlie", Marks = new Dictionary<string, int> { { "Math", 75 }, { "Science", 80 }, { "English", 72 } } },
            new Student { Name = "David", Marks = new Dictionary<string, int> { { "Math", 88 }, { "Science", 94 }, { "English", 91 } } },
            new Student { Name = "Eve", Marks = new Dictionary<string, int> { { "Math", 95 }, { "Science", 89 }, { "English", 90 } } }
        };

        // Calculate average, highest, and lowest per student
        foreach (var student in students)
        {
            var marks = student.Marks.Values;
            Console.WriteLine($"Student: {student.Name}");
            Console.WriteLine($"  Average Marks: {marks.Average():F2}");
            Console.WriteLine($"  Highest Marks: {marks.Max()}");
            Console.WriteLine($"  Lowest Marks: {marks.Min()}");
            Console.WriteLine();
        }

        // Find top 3 scorers by average marks using LINQ
        var top3 = students
            .Select(s => new
            {
                Name = s.Name,
                Average = s.Marks.Values.Average()
            })
            .OrderByDescending(s => s.Average)
            .Take(3);

        Console.WriteLine("Top 3 Scorers:");
        foreach (var student in top3)
        {
            Console.WriteLine($"  {student.Name} - Average Marks: {student.Average:F2}");
        }
    }
}
