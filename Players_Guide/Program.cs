using System;

// Challenge: The Prototype

Console.Title = "The Prototype";

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

for (int counter = 1; counter <= 100; counter++)
{
    if (counter % 3 == 0 && counter % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(counter + ": Fire/Electric");
    }
    else if (counter % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(counter + ": Fire");
    }
    else if (counter % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(counter + ": Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(counter + ": Normal");
    }
}

Console.ForegroundColor = ConsoleColor.White;