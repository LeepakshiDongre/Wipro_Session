using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(string news);
}

interface ISubject
{
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string news);
}

class NewsChannel : ISubject
{
    private List<IObserver> subscribers = new();

    public void Subscribe(IObserver observer) => subscribers.Add(observer);
    public void Unsubscribe(IObserver observer) => subscribers.Remove(observer);

    public void Notify(string news)
    {
        foreach (var s in subscribers)
            s.Update(news);
    }
}

class User : IObserver
{
    public string Name { get; }
    public User(string name) => Name = name;

    public void Update(string news) => Console.WriteLine($"{Name} received news: {news}");
}

class Program
{
    static void Main()
    {
        var channel = new NewsChannel();
        var user1 = new User("Alice");
        var user2 = new User("Bob");

        channel.Subscribe(user1);
        channel.Subscribe(user2);

        channel.Notify("New episode released!");
    }
}