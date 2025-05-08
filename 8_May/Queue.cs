using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating a queue of strings
        Queue<string> queue = new Queue<string>();


        // Enqueue elements
        queue.Enqueue("Amit");
        queue.Enqueue("Neha");
        queue.Enqueue("Ravi");
        queue.Enqueue("Priya");


        Console.WriteLine("Queue Elements:");

        foreach (var name in queue)
        {
            Console.WriteLine(name);
        }

        //Dequeue element
        Console.WriteLine("\nDequeued: " + queue.Dequeue());

        // Peek at the front element
        Console.WriteLine("Next in line: " + queue.Peek());
    }
}






using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Adding customers to the queue
        Queue<string> customers = new Queue<string>();


        
        customers.Enqueue("Rajesh");
        customers.Enqueue("Neha");
        customers.Enqueue("Priya");


        Console.WriteLine("Serving Customers:");
        while (customers.Count > 0)
        {
            Console.WriteLine("Serving: " + customers.Dequeue());
        }


    }
}




//POP AND PEEK  
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Creating a stack of strings
        Stack<string> books = new Stack<string>();


        // Pushing elements onto this stack
        books.Push("C# Programming");
        books.Push("Data Structures");
        books.Push("Machine Learning");


        Console.WriteLine("Books in the stack:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }

        //Popping an element
        Console.WriteLine("\nPopped: " + books.Pop());

        // Peeking at the top element
        Console.WriteLine("Next on the stack: " + books.Peek());

    }
}




