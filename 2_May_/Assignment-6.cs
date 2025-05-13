using System;

class Program
{
    static void PrintArrayRecursively(int[] arr, int index)
    {
        // Base condition: stop when index reaches array length
        if (index == arr.Length)
            return;

        Console.WriteLine(arr[index]); // Print current element
        PrintArrayRecursively(arr, index + 1); // Recursive call
    }

    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Array elements:");
        PrintArrayRecursively(numbers, 0);
    }
}
