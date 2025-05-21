//GREEDY ALGORITHM - COIN CHANGE
using System;
using System.Collections.Generic;

class CoinChange
{
    static void Solve(int amount, int[] denominations)
    {
        Array.Sort(denominations);
        Array.Reverse(denominations); //For greedy selection

        List<int> coinsUsed = new List<int>();

        foreach (int coin in denominations)
        {
            while (amount >= coin)
            {
                amount -= coin;
                coinsUsed.Add(coin);
            }
        }

        Console.WriteLine("Coins used:");
        foreach (int coin in coinsUsed)
        {
            Console.WriteLine(coin + " ");
        }
        Console.WriteLine($"\nTotal coins: {coinsUsed.Count}");
    }

    static void Main()
    {
        int[] denominations = { 1, 2, 5, 10, 20, 50, 100, 200, 500 };
        int amount = 880;
        Solve(amount, denominations);

    }
}