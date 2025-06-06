using System;

class Program
{
    // Bubble Sort Method
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++) // added -i for optimization
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j + 1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Print Array Method
    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 64, 25, 12, 22, 11 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        BubbleSort(numbers);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }
}
