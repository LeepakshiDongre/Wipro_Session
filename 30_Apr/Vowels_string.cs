//Count vowel in a string
using System;

class Program
{
    static int CountVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        int count = 0;

        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        string sentence = "Programming is fun!";
        Console.WriteLine("Number of vowels: " + CountVowels(sentence));
    }
}
