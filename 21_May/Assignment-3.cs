using System;
using System.Collections.Generic;

class FirstUniqueChar
{
    static char? FindFirstUnique(string input)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        foreach (char c in input)
        {
            if (freq[c] == 1)
                return c;
        }

        return null;
    }

    static void Main()
    {
        string input = "swiss";
        char? result = FindFirstUnique(input);

        if (result.HasValue)
            Console.WriteLine("First non-repeating character: " + result);
        else
            Console.WriteLine("No non-repeating character found.");
    }
}