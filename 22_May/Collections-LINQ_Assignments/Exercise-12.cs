using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string> { "Alice", "Eve", "Bob", "Oscar", "Uma", "John" };

        var namesStartingWithVowel = names.Where(n => "AEIOUaeiou".Contains(n[0])).ToList();

        Console.WriteLine("Names Starting with a Vowel:");
        foreach (var name in namesStartingWithVowel)
        {
            Console.WriteLine(name);
        }
    }
}
