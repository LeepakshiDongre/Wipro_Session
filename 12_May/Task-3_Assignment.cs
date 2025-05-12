using System;


interface IAnimalActions
{
    void Eat();
    void Sleep();
}
class Lion : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Loin is eating meat");
    }
    public void Sleep()
    {
        Console.WriteLine("Loin is sleeping");
    }
}
class Elephant : IAnimalActions
{
    public void Eat()
    {
        Console.WriteLine("Elephant is eating grass");
    }
    public void Sleep()
    {
        Console.WriteLine("Elephant is sleeping");
    }
}
class Program
{
    static void Main()
    {
        IAnimalActions lion = new Lion();
        IAnimalActions elephant = new Elephant();

        lion.Eat();
        lion.Sleep();

        elephant.Sleep();
        elephant.Eat();
    }
}