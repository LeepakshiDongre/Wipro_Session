//PRINT DUPLICATE WORDS IN A SENTENCE
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string sentence = "this is a test and this test is fun";
        string[] words = sentence.Split(' ');
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        Console.Write("Duplicate words: ");
        foreach (var pair in wordCount)
        {
            if (pair.Value > 1)
                Console.Write(pair.Key + ", ");
        }
    }
}
