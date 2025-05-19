using System;
using System.Collections.Generic;

class Book
{
    public string Title;
    public string Author;

}
class Program
{
    static void Main()
    {
        Queue<Book> borrowedBooks = new Queue<Book>();
        borrowedBooks.Enqueue(new Book { Title = "Book A", Author = "Author 1" });
        borrowedBooks.Enqueue(new Book { Title = "Book B", Author = "Author 2" });
        borrowedBooks.Enqueue(new Book { Title = "Book C", Author = "Author 3" });
        borrowedBooks.Enqueue(new Book { Title = "Book D", Author = "Author 4" });
        borrowedBooks.Enqueue(new Book { Title = "Book E", Author = "Author 5" });

        Console.WriteLine("Next book to return:");
        Book nextReturn = borrowedBooks.Peek();
        Console.WriteLine($"{nextReturn.Title} by {nextReturn.Author}");

        Console.WriteLine("\nReturning book...");
        borrowedBooks.Dequeue();

        Stack<Book> newBooks = new Stack<Book>();
        newBooks.Push(new Book { Title = "New Book 1", Author = "Author X" });
        newBooks.Push(new Book { Title = "New Book 2", Author = "Author Y" });
        newBooks.Push(new Book { Title = "New Book 3", Author = "Author Z" });

        Console.WriteLine("\nLast purchased book:");
        Book lastPurchased = newBooks.Peek();
        Console.WriteLine($"{lastPurchased.Title} by {lastPurchased.Author}");

        Console.WriteLine("\nProcessing a new book...");
        newBooks.Pop();

        Console.WriteLine("\nRemaining Borrowed Books:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
        Console.WriteLine("\nRemaining New Books:");
        foreach (var book in newBooks)
        {
            Console.WriteLine($"{book.Title} {book.Author}");
        }
    }
}