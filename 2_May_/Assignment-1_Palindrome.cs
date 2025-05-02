using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string original = Console.ReadLine();
        string reversed = "";

        // Reverse the string
        for (int i = original.Length - 1; i >= 0; i--)
        {
            reversed += original[i];
        }

        if (original.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine(original + " is a Palindrome.");
        }
        else
        {
            Console.WriteLine(original + " is NOT a Palindrome.");
        }
    }
}
