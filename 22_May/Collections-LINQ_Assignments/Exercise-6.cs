using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string sentence = "C# is great and C# is fun";
        
        var wordFrequency = sentence.Split(' ')
            .GroupBy(w => w.ToLower())
            .Select(g => new { Word = g.Key, Count = g.Count() })
            .ToList();

        foreach (var word in wordFrequency)
        {
            Console.WriteLine($"{word.Word}: {word.Count}");
        }
    }
}
