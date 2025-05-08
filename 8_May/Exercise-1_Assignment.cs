using System;
using System.Collections;
using System.Collections.Generic;

class Studentlist
{
    static void Main()
    {
        //1.Create an array list to store student names
        ArrayList students = new ArrayList();

        //2. Add 5 names to the students list
        students.Add("Amit");
        students.Add("Bhavana");
        students.Add("Chirag");
        students.Add("Deepa");
        students.Add("Eshan");

        Console.WriteLine("Initial Student List:");
        foreach(string name in students)
        {
            Console.WriteLine(name);
        }

        //3. Remove a specific name by value
        students.Remove("Chirag");

        //4. Display the list of names after removal 
        Console.WriteLine("\nAfter Removal students name:");
        foreach(string name in students)
        {
            Console.WriteLine(name);
        }

        //5. Check if the name exists in the list 
        string searchName = "Deepa";
        if(students.Contains(searchName))
        {
            Console.WriteLine($"\n{searchName}  is present in the list.");
        }

        else
        {
            Console.WriteLine($"\n{searchName}  is not present in the list.");
        }
    }
}
