using System;

class Program
{
    static void Main()
    {
        // Example array
        int[,] myArray = { { 3, 5 }, { -1, 12 }, { 4, 0 } };

        // Call the FindMax method and print the result
        int max = FindMax(myArray);
        Console.WriteLine("Max value: " + max);

        // Wait for user input before closing the console window
        Console.ReadKey();
    }

    static int FindMax(int[,] array)
    {
        // Check if any dimension is zero, indicating an empty array
        if (array.GetLength(0) == 0 || array.GetLength(1) == 0)
        {
            return -1;
        }

        int max = array[0, 0];

        // Iterate through the array to find the maximal value
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        return max;
    }
}
