// Remove Duplicates from Array
using System;

using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 2, 4, 1 };
        HashSet<int> unique = new HashSet<int>();

        Console.WriteLine("Array without duplicates:");
        foreach (int num in numbers)
        {
            if (!unique.Contains(num))
            {
                Console.Write(num + " ");
                unique.Add(num);
            }
        }
    }
}
