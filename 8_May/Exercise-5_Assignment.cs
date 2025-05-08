using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Create the phone dictionary
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // 2. Add 5 contacts
        phoneBook.Add("Alice", "123-456-7890");
        phoneBook.Add("Bob", "234-567-8901");
        phoneBook.Add("Charlie", "345-678-9012");
        phoneBook.Add("Diana", "456-789-0123");
        phoneBook.Add("Edward", "567-890-1234");

        // 3. Update a phone number for a specific name (e.g., update Charlie)
        phoneBook["Charlie"] = "999-999-9999";

        // 4. Check if a particular name exists
        string nameToCheck = "Bob";
        if (phoneBook.ContainsKey(nameToCheck))
        {
            Console.WriteLine($"{nameToCheck} exists in the phone book with number: {phoneBook[nameToCheck]}");
        }
        else
        {
            Console.WriteLine($"{nameToCheck} does not exist in the phone book.");
        }

        // 5. Print all contacts
        Console.WriteLine("\nAll Contacts in the Phone Book:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }
    }
}
