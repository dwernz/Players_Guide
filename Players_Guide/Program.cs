using System;

// Challenge: Repairing the Clocktower

Console.Title = "Repairing the Clocktower";

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

Console.Write("Input a number: ");

string numberString = Console.ReadLine();

int number = Convert.ToInt32(numberString);

if (number % 2 == 0)
{
    Console.WriteLine("Tick");
}
else
{
    Console.WriteLine("Tock");
}