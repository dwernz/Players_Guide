using System;

// Challenge: The Replicator of D'To

Console.Title = "The Replicator of D'To";

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

int[] array1 = new int[5];

for (int counter = 1; counter <= 5; counter++)
{
    Console.Write("Enter a number to be stored in the array: ");
    array1[counter - 1] = Convert.ToInt32(Console.ReadLine()); 
}

int[] array2 = new int[5];

for (int counter = 0; counter <= 4; counter++)
{
    array2[counter] = array1[counter];
}

Console.Write("Array1: ");

foreach (int i in array1)
{
    Console.Write("{0} ", i);
}

Console.Write("\nArray2: ");
foreach (int i in array2)
{
    Console.Write("{0} ", i);
}