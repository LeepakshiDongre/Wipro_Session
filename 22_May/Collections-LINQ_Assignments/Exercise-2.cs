using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>
        {
            { "John", "123-456-7890" },
            { "Mary", "234-567-8901" },
            { "Alex", "345-678-9012" }
        };

        // Display all contacts
        Console.WriteLine("Phone Book:");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Key}: {contact.Value}");
        }

        // Ask for a name and display phone number
        Console.Write("\nEnter a name to search: ");
        string name = Console.ReadLine();
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s phone number: {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found.");
        }
    }
}
