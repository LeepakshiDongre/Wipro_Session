using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 5, 60 };
        int first = int.MinValue;
        int second = int.MinValue;

        foreach (int num in numbers)
        {
            if (num >  first)
            {
                second = first;
                first = num;
            }
            else if (num > second && num != first)
            {
                second = num;
            }
        }

        Console.WriteLine("Second largest: " + second);
    }
}
