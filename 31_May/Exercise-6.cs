
using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsBorrowed { get; set; } = false;
    public Student BorrowedBy { get; set; }
    public DateTime? DueDate { get; set; }

    public override string ToString()
    {
        string status = IsBorrowed ? $"Borrowed by {BorrowedBy.Name}, Due: {DueDate?.ToShortDateString()}" : "Available";
        return $"[{Id}] {Title} - {status}";
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString() => $"[{Id}] {Name}";
}

public class Library
{
    private List<Book> books = new List<Book>();
    private List<Student> students = new List<Student>();

    public void AddBook(Book book)
    {
        if (!books.Any(b => b.Id == book.Id))
        {
            books.Add(book);
            Console.WriteLine($"Book '{book.Title}' added.");
        }
        else
        {
            Console.WriteLine($"Book with Id {book.Id} already exists.");
        }
    }

    public void DeleteBook(int bookId)
    {
        var book = books.FirstOrDefault(b => b.Id == bookId);
        if (book != null)
        {
            if (book.IsBorrowed)
            {
                Console.WriteLine("Cannot delete borrowed book.");
                return;
            }
            books.Remove(book);
            Console.WriteLine($"Book '{book.Title}' deleted.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void AddStudent(Student student)
    {
        if (!students.Any(s => s.Id == student.Id))
        {
            students.Add(student);
            Console.WriteLine($"Student '{student.Name}' added.");
        }
        else
        {
            Console.WriteLine($"Student with Id {student.Id} already exists.");
        }
    }

    public void BorrowBook(int bookId, int studentId, int days)
    {
        var book = books.FirstOrDefault(b => b.Id == bookId);
        var student = students.FirstOrDefault(s => s.Id == studentId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }
        if (book.IsBorrowed)
        {
            Console.WriteLine("Book already borrowed.");
            return;
        }

        book.IsBorrowed = true;
        book.BorrowedBy = student;
        book.DueDate = DateTime.Now.AddDays(days);

        Console.WriteLine($"Book '{book.Title}' borrowed by {student.Name} until {book.DueDate?.ToShortDateString()}.");
    }

    public void ReturnBook(int bookId)
    {
        var book = books.FirstOrDefault(b => b.Id == bookId);

        if (book == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }
        if (!book.IsBorrowed)
        {
            Console.WriteLine("Book is not borrowed.");
            return;
        }

        book.IsBorrowed = false;
        Console.WriteLine($"Book '{book.Title}' returned by {book.BorrowedBy.Name}.");
        book.BorrowedBy = null;
        book.DueDate = null;
    }

    public void ListBooks()
    {
        Console.WriteLine("\nBooks in Library:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }

    public void ListStudents()
    {
        Console.WriteLine("\nRegistered Students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}

class Program
{
    static void Main()
    {
        var library = new Library();

        // Add some students
        library.AddStudent(new Student { Id = 1, Name = "Alice" });
        library.AddStudent(new Student { Id = 2, Name = "Bob" });

        // Add some books
        library.AddBook(new Book { Id = 101, Title = "C# Programming" });
        library.AddBook(new Book { Id = 102, Title = "Data Structures" });
        library.AddBook(new Book { Id = 103, Title = "Operating Systems" });

        library.ListBooks();
        library.ListStudents();

        // Borrow book
        library.BorrowBook(101, 1, 14);  // Alice borrows book 101 for 14 days
        library.BorrowBook(102, 2, 7);   // Bob borrows book 102 for 7 days

        library.ListBooks();

        // Try deleting a borrowed book
        library.DeleteBook(101);

        // Return book
        library.ReturnBook(101);

        // Now delete
        library.DeleteBook(101);

        library.ListBooks();
    }
}
