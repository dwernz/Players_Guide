using System;

// Challenge: The Laws of Freach

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentMinimum = int.MaxValue; // Start higher than anything in the array.

foreach (int i in array)
{
    if (currentMinimum > i)
    {
        currentMinimum = i;
    }
}

Console.WriteLine("Minimum: " + currentMinimum);

int total = 0;

foreach (int i in array)
{
    total += i;
}

Console.WriteLine("Average: " + ((double) total / array.Length));