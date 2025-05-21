//HASHING - FIRST NON-REAPEATING CHARACTER
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string input = "Ramya";

        Dictionary<char, int> charcount = new Dictionary<char, int>();

        // Step 1: Count the frequency of each character
        foreach (char c in input)
        {
            if (charcount.ContainsKey(c))
                charcount[c]++;
            else
                charcount[c] = 1;
        }

        // Step 2: Find the first character with frequency 1
        foreach (char c in input)
        {
            if (charcount[c] == 1)
            {
                Console.WriteLine("First non repeating character: " + c);
                return;
            }
        }

        Console.WriteLine("No non repeating character found");
    }
}