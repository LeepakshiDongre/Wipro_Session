//RECURSION - TOWER OF HONAI
using System;

class TowerOfHanoi
{
    static void Solve(int n, char source, char destination, char auxiliary)
    {
        if (n == 1)
        {
            Console.WriteLine($"Move disk 1 from {source} to {destination}");
            return;
        }
        Solve(n - 1, source, auxiliary, destination);
        Console.WriteLine($"Move disk {n} from {source} to {destination}");
        Solve(n - 1, auxiliary, destination, source);

    }

    static void Main()
    {
        int n = 3;
        Solve(n, 'A', 'C', 'B');
    }
}