using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new()
        {
            new Student { Name = "Alice", Score = 85  },
            new Student { Name = "Bob", Score = 75  },
            new Student { Name = "Charlie", Score = 92  },

        };

        var highScorers = students
           .Where(s => s.Score > 80)
           .OrderByDescending(s => s.Score);
        foreach (var student in highScorers)
            Console.WriteLine($"{student.Name}: {student.Score}");

    }
}