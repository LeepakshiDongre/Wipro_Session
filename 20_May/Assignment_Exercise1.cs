using System;

class SortingAlgorithms
{
    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
    }

    static void SelectionSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < arr.Length; j++)
                if (arr[j] < arr[minIndex])
                    minIndex = j;
            int temp = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        Random rand = new Random();
        int[] original = new int[20];
        for (int i = 0; i < original.Length; i++)
            original[i] = rand.Next(1, 101);

        int[] arr1 = (int[])original.Clone();
        int[] arr2 = (int[])original.Clone();
        int[] arr3 = (int[])original.Clone();

        Console.WriteLine("Original Array:");
        PrintArray(original);

        var start = DateTime.Now.Ticks;
        BubbleSort(arr1);
        var end = DateTime.Now.Ticks;
        Console.WriteLine("\nBubble Sort:");
        PrintArray(arr1);
        Console.WriteLine("Time (ticks): " + (end - start));

        start = DateTime.Now.Ticks;
        SelectionSort(arr2);
        end = DateTime.Now.Ticks;
        Console.WriteLine("\nSelection Sort:");
        PrintArray(arr2);
        Console.WriteLine("Time (ticks): " + (end - start));

        start = DateTime.Now.Ticks;
        InsertionSort(arr3);
        end = DateTime.Now.Ticks;
        Console.WriteLine("\nInsertion Sort:");
        PrintArray(arr3);
        Console.WriteLine("Time (ticks): " + (end - start));
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : "\n"));
    }
}
