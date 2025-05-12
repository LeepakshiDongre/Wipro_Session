using System;

abstract class Book
{
    public abstract void Read();

    public void GetInfo()
    {
        Console.WriteLine("This is a book");
    }
}
class FictionBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a fiction book");
    }
}
class ScienceBook : Book
{
    public override void Read()
    {
        Console.WriteLine("Reading a science book");
    }
}
class Program
{
    static void Main()
    {
        Book Fiction = new FictionBook();
        Book Science = new ScienceBook();

        Fiction.GetInfo();
        Fiction.Read();

        Science.GetInfo();
        Science.Read();
    }
}

