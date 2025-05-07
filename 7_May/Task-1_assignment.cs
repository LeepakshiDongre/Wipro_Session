//PRINT THE FREQUENCY OF EACH ELEMENT IN A ARRAY
using System;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 4 };
        int[] values = new int[arr.Length];
        int[] counts = new int[arr.Length];
        int uniqueCount = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int index = -1;
            for (int j = 0; j < uniqueCount; j++)
            {
                if (values[j] == arr[i])
                {
                    index = j;
                    break;
                }
            }

            if (index != -1)
            {
                counts[index]++;
            }
            else
            {
                values[uniqueCount] = arr[i];
                counts[uniqueCount] = 1;
                uniqueCount++;
            }
        }

        for (int i = 0; i < uniqueCount; i++)
        {
            Console.WriteLine($"{values[i]} appears {counts[i]} time(s)");
        }
    }
}

