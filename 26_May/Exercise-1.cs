using System;

abstract class Animal
{
    public string Name { get; set; }
    public abstract void MakeSound();

}
class Lion : Animal
{
    public override void MakeSound() => Console.WriteLine($"{Name} the Lion roars!");
   
}

class Elephant : Animal
{
    public override void MakeSound() => Console.WriteLine($"{Name} the Elephant trumpets!");

}
class Monkey : Animal
{
    public override void MakeSound() => Console.WriteLine($"{Name} the Monkey Chatters!");

}
class Program

{
    static void Main()
    {

        Animal[] zoo =
        {
        new Lion { Name = "Simba"},
        new Elephant { Name = "Dumbo" },
        new Monkey { Name = "George"}
    };

        foreach (var animal in zoo)
        {
            animal.MakeSound();    // Polymorphism in action

        }
    }
}



