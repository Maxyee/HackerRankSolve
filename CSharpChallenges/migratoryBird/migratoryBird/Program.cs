using System;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> arr = new List<int>(Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp)));

        int[] counts = new int[6]; // Initialize an array to keep track of counts for each bird type

        // Loop through the input list and increment the count for each bird type
        foreach (int bird in arr)
        {
            counts[bird]++;
        }

        int maxCount = 0;
        int maxType = 0;

        // Loop through the count array to find the bird type with the highest count
        for (int i = 1; i <= 5; i++)
        {
            if (counts[i] > maxCount)
            {
                maxCount = counts[i];
                maxType = i;
            }
        }

        Console.WriteLine(maxType);
    }
}
