using System;

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract void MakeSound();

    public void Feed()
    {
        Console.WriteLine($"Feeding the {Name}...");
    }
}

class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Roar!");
    }
}

class Elephant : Animal
{
    public Elephant(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Trumpet!");
    }
}

class Program
{
    static void Main()
    {
        Animal lion = new Lion("Leo", 5);
        Animal elephant = new Elephant("Ella", 10);

        lion.MakeSound();
        lion.Feed();

        elephant.MakeSound();
        elephant.Feed();
    }
}
