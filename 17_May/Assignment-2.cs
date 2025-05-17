using System;


interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);
}
class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email : {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Email");
    }
}
class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email : {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Email");
    }
}
class Program
{
    static void Main()
    {
        ISupportTicket email = new EmailSupport();
        ISupportTicket phone = new PhoneSupport();

        email.CreateTicket("Login not working");
        email.ResolveTicket(101);

        phone.CreateTicket("Payment failed");
        phone.ResolveTicket(102);
    }
}
