using System;

class Program
{
    static void Main()
    {
        string sentence = "Learning C# is fun";
        int wordCount = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine("Number of words:" + wordCount);
    }
}