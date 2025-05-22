using System;
using System.Collections.Generic;

interface IEnrollable
{
    void Enroll(Course course);
}

class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }

    public Course(int id, string title, double fee)
    {
        Id = id;
        Title = title;
        Fee = fee;
    }
}

class User : IEnrollable
{
    public string Name { get; set; }
    public List<Course> EnrolledCourses { get; set; } = new List<Course>();

    public void Enroll(Course course)
    {
        EnrolledCourses.Add(course);
    }

    public void Enroll(Course course, string couponCode)
    {
        if (couponCode == "DISCOUNT")
        {
            course.Fee *= 0.9; // Apply 10% discount
        }
        EnrolledCourses.Add(course);
    }

    public void PrintEnrolledCourses()
    {
        Console.WriteLine($"{Name} has enrolled in:");
        foreach (var course in EnrolledCourses)
        {
            Console.WriteLine($"{course.Title} - ${course.Fee}");
        }
    }
}

class Program
{
    static void Main()
    {
        Course course1 = new Course(1, "C# Basics", 100);
        Course course2 = new Course(2, "Advanced C#", 200);

        User user = new User { Name = "Alice" };

        user.Enroll(course1);
        user.Enroll(course2, "DISCOUNT");

        user.PrintEnrolledCourses();
    }
}
