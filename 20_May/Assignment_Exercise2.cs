using System;

class SearchingAlgorithms
{
    static int LinearSearch(int[] arr, int key, out int comparisons)
    {
        comparisons = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            comparisons++;
            if (arr[i] == key)
                return i;
        }
        return -1;
    }

    static int BinarySearch(int[] arr, int key, out int comparisons)
    {
        int low = 0, high = arr.Length - 1;
        comparisons = 0;

        while (low <= high)
        {
            comparisons++;
            int mid = (low + high) / 2;
            if (arr[mid] == key)
                return mid;
            else if (arr[mid] < key)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }

    static void BubbleSort(int[] arr) // Helper to sort the array
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

    static void Main()
    {
        Random rand = new Random();
        int[] arr = new int[50];
        for (int i = 0; i < arr.Length; i++)
            arr[i] = rand.Next(1, 201);

        BubbleSort(arr); // sort for binary search

        int key = arr[rand.Next(arr.Length)];

        Console.WriteLine("Sorted Array:");
        PrintArray(arr);
        Console.WriteLine("Key to find: " + key);

        int comparisons;
        int posLinear = LinearSearch(arr, key, out comparisons);
        Console.WriteLine("\nLinear Search: Index = " + posLinear + ", Comparisons = " + comparisons);

        int posBinary = BinarySearch(arr, key, out comparisons);
        Console.WriteLine("Binary Search: Index = " + posBinary + ", Comparisons = " + comparisons);
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + (i < arr.Length - 1 ? ", " : "\n"));
    }
}
