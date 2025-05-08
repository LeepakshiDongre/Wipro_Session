using System;
using System.Collections.Generic;


class  Student
{
    public int ID { get; set; }
    public string Name { get; set; }
}
class Program
{
    static void Main()
    {
        List<Student> student = new List<Student>()
        {
            new Student { ID = 1, Name = "Alice" },
            new Student { ID = 2, Name = "Bob" }
        };

        //Adding  another student
        student.Add(new Student { ID = 3, Name = "Charlie" });


        foreach (var Student in student)
        {
            Console.WriteLine($"ID: {Student.ID}, Name: {Student.Name}");

        }


    }
}


//fINDING INDEX VALUE
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 20, 40, 60, 80, 100 };

        int indeX = numbers.IndexOf(60);
        Console.WriteLine("Index of 60: " + indeX);

        bool contains = numbers.Contains(40);
        Console.WriteLine("Contains 40: " + contains);
       
        

       


    }
}
