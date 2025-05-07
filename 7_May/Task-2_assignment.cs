// Find Longest word in a sentence
using System;


class Program
{
    static void Main()
    {
        string sentence = "Learning C# is really interesting";
        string[] words = sentence.Split(' ');
        string longest = "";

        foreach (string word in words)
        {
            if (word.Length > longest.Length) 
                longest = word;
        }

        Console.WriteLine("Longest word: " + longest);
      
    }
}