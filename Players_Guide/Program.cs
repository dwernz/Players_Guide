using System;

// Challenge: The Dominion of Kings

Console.Title = "The Dominion of Kings";

Console.BackgroundColor = ConsoleColor.Yellow;
Console.ForegroundColor = ConsoleColor.Black;

Console.Clear();

Console.Write("How many provinces does the King rule? ");
string provincesString = Console.ReadLine();
Console.Clear();
Console.Write("How many duchies does the King rule? ");
string duchiesString = Console.ReadLine();
Console.Clear();
Console.Write("How many estates does the King rule? ");
string estatesString = Console.ReadLine();
Console.Clear();

int provinces = Convert.ToInt32(provincesString);
int duchies = Convert.ToInt32(duchiesString);
int estates = Convert.ToInt32(estatesString);

int estateTotal = estates * 1;
int duchiesTotal = duchies * 3;
int provinceTotal = provinces * 6;

int total = estateTotal + duchiesTotal + provinceTotal;

Console.WriteLine($"Total points for the King is {total}");