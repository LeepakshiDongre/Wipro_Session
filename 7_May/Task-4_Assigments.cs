using System;
using System.Collections;

class Program
{
    static void Main()
    {
        //1. Create an ArrayList of student names
        ArrayList students = new ArrayList();

        //2. Add 5 names to the list
        students.Add("Rahul");
        students.Add("Sneha");
        students.Add("Amit");
        students.Add("Priya");
        students.Add("Neha");

        //3. Check if a specific name exists 
        string checkName = "Amit";
        if (students.Contains(checkName))
        {
            Console.WriteLine(checkName + "is in the list.");
        }
        else
        {
            Console.WriteLine(checkName + "is not in the list.");
        }

        //4. REMOVE THE SECOND NAME (INDEX 1)
        students.RemoveAt(1);  // Removes Sneha

        // 5. DISPLAY THE FINAL LIST
        Console.WriteLine("/nFinal Student List:");
        foreach(string name  in students)
        {
            Console.WriteLine(name);
        }


    }
}