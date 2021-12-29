using System;

// Challenge: The Defense of Consolas

Console.Title = "The Defense of Consolas";

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

Console.Write("Target Row? ");
string targetRowString = Console.ReadLine();
Console.Clear();
Console.Write("Target Column? ");
string targetColumnString = Console.ReadLine();
Console.Clear();

int targetRow = Convert.ToInt32(targetRowString);
int targetColumn = Convert.ToInt32(targetColumnString);

Console.Beep(500, 500);
Console.Beep(400, 500);
Console.Beep(300, 250);

Console.WriteLine($"Deploy to:");
Console.WriteLine($"({targetRow}, {targetColumn - 1})");
Console.WriteLine($"({targetRow - 1}, {targetColumn}");
Console.WriteLine($"({targetRow}, {targetColumn + 1})");
Console.WriteLine($"({targetRow + 1}, {targetColumn})");