using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph:");
        string paragraph = Console.ReadLine();

        // Split paragraph by spaces and common punctuation marks
        char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ';', ':', '-', '\'', '\"', '(', ')', '[', ']', '{', '}', '\n', '\r', '\t' };
        var rawWords = paragraph.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

        // Clean words: remove any non-letter characters from start/end, convert to lowercase
        List<string> words = new List<string>();
        foreach (var rawWord in rawWords)
        {
            // Remove any non-letter chars at start/end of the word
            string cleanWord = rawWord.Trim().ToLower();

            // Remove any remaining non-letter characters inside the word (optional)
            cleanWord = new string(cleanWord.Where(char.IsLetter).ToArray());

            if (!string.IsNullOrEmpty(cleanWord))
                words.Add(cleanWord);
        }

        // 1. Word Frequency
        var wordFrequency = words
            .GroupBy(w => w)
            .ToDictionary(g => g.Key, g => g.Count());

        Console.WriteLine("\nWord Frequency:");
        foreach (var pair in wordFrequency.OrderByDescending(wf => wf.Value))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        // 2. Vowel and Consonant Count
        int vowelCount = 0;
        int consonantCount = 0;
        string vowels = "aeiou";

        foreach (char c in paragraph.ToLower())
        {
            if (char.IsLetter(c))
            {
                if (vowels.Contains(c))
                    vowelCount++;
                else
                    consonantCount++;
            }
        }

        Console.WriteLine($"\nVowel Count: {vowelCount}");
        Console.WriteLine($"Consonant Count: {consonantCount}");

        // 3. Longest and Shortest Word
        if (words.Any())
        {
            var longestWord = words.OrderByDescending(w => w.Length).First();
            var shortestWord = words.OrderBy(w => w.Length).First();

            Console.WriteLine($"\nLongest word: {longestWord}");
            Console.WriteLine($"Shortest word: {shortestWord}");
        }
        else
        {
            Console.WriteLine("\nNo valid words found in input.");
        }
    }
}
