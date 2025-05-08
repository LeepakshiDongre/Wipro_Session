using System;
using System.Collections;
using System.Collections.Generic;

class IntegerOperations
{
    static void Main()
    {
        //1. Create an array list of integers 
        ArrayList numbers = new ArrayList();
        Random rand = new Random();


        //2. Add 10 random numbers between 1 and 50
        for(int i = 0; i< 10; i++)
        {
            numbers.Add(rand.Next(1, 51)); //random numbers from 1 to 50
        }
        Console.WriteLine("Original Numbers:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num); //using writeLine for each number
        }

        //Sort the list
        numbers.Sort();


        //Find min and max
        int min = (int)numbers[0];
        int max = (int)numbers[numbers.Count - 1];

        // Calculate Average
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;

        }

        double avg = (double)sum / numbers.Count;

        //Display Results
        Console.WriteLine("\nSorted Numbers:");
        foreach(int num in numbers)
        {
            Console.WriteLine(num); //using WriteLine
        }

        Console.WriteLine("\nMinimum Value: " + min);
        Console.WriteLine("\nMaximum Value: " + max);
        Console.WriteLine("\nAverage Value: " + avg);
    }
}
