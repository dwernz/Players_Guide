using System;

// Challenge: Countdown

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

Countdown(10);

int Countdown(int number)
{
    if (number == 1)
    {
        Console.Write(1);
        return 1;
    }
    else
    {
        Console.Write(number + " ");
        return Countdown(number - 1);
    }
}