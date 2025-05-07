//PRINT DUPLICATE WORDS IN A SENTENCE
using System;

class Program
{
    static void Main()
    {
        string sentence = "this is a test and this test is fun";
        string[] words = sentence.Split(' ');
        string[] uniqueWords = new string[words.Length];
        int[] counts = new int[words.Length];
        int uniqueCount = 0;

        for (int i = 0; i < words.Length; i++)
        {
            int index = -1;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (uniqueWords[j] == words[i])
                {
                    index = j;
                    break;
                }
            }

            if (index != -1)
            {
                counts[index]++;
            }
            else
            {
                uniqueWords[uniqueCount] = words[i];
                counts[uniqueCount] = 1;
                uniqueCount++;
            }
        }

        Console.Write("Duplicate words: ");
        bool first = true;
        for (int i = 0; i < uniqueCount; i++)
        {
            if (counts[i] > 1)
            {
                if (!first) Console.Write(", ");
                Console.Write(uniqueWords[i]);
                first = false;
            }
        }

        Console.WriteLine();
    }
}

