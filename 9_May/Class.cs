using System;

class Student
{
    // Fields
    public int RollNumber;
    public string Name;
    public int Marks;

    public void PrintDetails()
    {
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Marks: {Marks}");
    }
}


class Program
{
    static void Main()
    {
        // Create an instance of the Student class
        Student student1 = new Student();

        // Assign values to student1
        student1.RollNumber = 101;
        student1.Name = "John Doe";
        student1.Marks = 85;

        // Print details
        student1.PrintDetails();
    }
}

// Create a Class Student by adding class to project
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student

    {
        // Fields
        public int RollNumber;
        public string Name;
        public int Marks;

        public void PrintDetails()
        {
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Marks: {Marks}");
        }

    }
}

// Now Insert values into class methods
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student { RollNumber = 101, Name = "Neha", Marks = 90 };
            Student student2 = new Student { RollNumber = 102, Name = "Ravi", Marks = 75 };

            student1.PrintDetails();
            student2.PrintDetails();

        }

    }
}





Instace of class (Inheritance)
using System;
class Animal
{

    public string Name;
    public string Species;

    //Method to display animal details
    public void DisplayAnimal()
    {
        Console.WriteLine($"nimal Name: {Name}");
        Console.WriteLine($"Species: {Species}");

    }


}
class Dog : Animal
{
    public string Breed;

    //Method to display dog details 
    public void DisplayDog()
    {
        Console.WriteLine($"Breed: {Breed}");
    }

}

class Program
{
    static void Main()
    {
        //Creating an object of Dog class 
        Dog myDog = new Dog();
        myDog.Name = "Buddy";
        myDog.Species = "Canine";
        myDog.Breed = "Labrador";

        //Diplay animal details
        myDog.DisplayAnimal();

        myDog.DisplayDog();

    }
}