using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating a dictionary  to store student IDs and names
        Dictionary<int, string> students = new Dictionary<int, string>();

        //Adding elements
        students.Add(101, "Alice");
        students.Add(102, "Bob");
        students.Add(103, "Charlie");

        //Accessing values using keys
        Console.WriteLine("Student with ID 102: " + students[102]);

        //Looping through the elements
         foreach (var pair in students)
        {
            Console.WriteLine($"ID: {pair.Key}, Name: {pair.Value}");
        }
    }
}





//UPDATE IN DICTIONARY 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<int, string> employees = new Dictionary<int, string>
        {
            { 1, "Amit" },
            { 2, "Anjali" },
            { 3, "Sandeep" }
        };

        // Updating the name for Employee ID 2
        employees[2] = "Ananya";
            
        Console.WriteLine("Updated Employee List:");

        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.Key}, Name: {emp.Value}");
        }
    }
}




//Check value in dictionary
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<string, string> cities = new Dictionary<string, string>
        {
            { "Mumbai", "Maharashtra" },
            { "Bangalore", "Karnataka" },
            { "Chennai", "Tamil Nadu" },
            { "Kolkata", "West Bengal" },
            { "Hyderabad", "Telangana" }


        };

        
        Console.WriteLine("Indian Cities and their States:");

        foreach (var city in cities)
        {
            Console.WriteLine($"ID: {city.Key}, Name: {city.Value}");
        }

        //Check if a specific city exists
        if (cities.ContainsKey("Chennai"))
        {
            Console.WriteLine("Chennai is present in the dictionary.");
        }
    }
}