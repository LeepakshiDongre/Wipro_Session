using System;

interface IBankAccount
{
    void Deposit(double amount);
    void Withdraw(double amount);
    void CheckBalance();

}
class SavingsAccount : IBankAccount
{
    public void Deposit(double amount)
    {
        Console.WriteLine("Deposited"  + amount +  "into savings account");
    }
    public void Withdraw(double amount)
    {
        Console.WriteLine("Withdraw" + amount + "from savings account");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Checking Balance from savings account");
    }

}

class CuurentAccount : IBankAccount
{
    public void Deposit(double amount)
    {
        Console.WriteLine("Deposited" + amount + "into current account");
    }
    public void Withdraw(double amount)
    {
        Console.WriteLine("Withdraw" + amount + "from current account");
    }
    public void CheckBalance()
    {
        Console.WriteLine("Checking Balance from current account");
    }

}

class Program
{
    static void Main()
    {
        IBankAccount savings = new SavingsAccount();
        IBankAccount current = new  CuurentAccount();

        savings.Deposit(1000);
        savings.Withdraw(500);
        savings.CheckBalance();

        current.Deposit(2000);
        current.Withdraw(800);
        current.CheckBalance();


       
    }
}