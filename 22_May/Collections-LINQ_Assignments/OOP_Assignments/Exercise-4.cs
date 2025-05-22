using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }

    public Book(int id, string title, string author, bool isAvailable)
    {
        Id = id;
        Title = title;
        Author = author;
        IsAvailable = isAvailable;
    }
}

class Library
{
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return Books.Where(b => b.Author.ToLower().Contains(author.ToLower())).ToList();
    }

    public List<Book> SearchByTitle(string title)
    {
        return Books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        library.AddBook(new Book(1, "C# Programming", "John Doe", true));
        library.AddBook(new Book(2, "Learning Python", "Jane Smith", false));
        library.AddBook(new Book(3, "Mastering Java", "John Doe", true));

        Console.WriteLine("Search by Author (John Doe):");
        var booksByAuthor = library.SearchByAuthor("John Doe");
        foreach (var book in booksByAuthor)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }

        Console.WriteLine("\nSearch by Title (Learning):");
        var booksByTitle = library.SearchByTitle("Learning");
        foreach (var book in booksByTitle)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}
