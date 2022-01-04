using System;

// Challenge: Taking a number

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

Console.WriteLine("AskForNumber result: " + AskForNumber("What is 2 + 2 ?"));
Console.WriteLine("AskForNumberInRange result: " + AskForNumberInRange("Type a number between 1 and 10", 1, 10));

int AskForNumber(string text)
{
    Console.WriteLine(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());

    return number;
}

int AskForNumberInRange(string text, int min, int max)
{
    Console.WriteLine(text + " ");
    int number = Convert.ToInt32(Console.ReadLine());

    while (number > max || number < min)
    {
        Console.WriteLine("Number outside of range, please enter a number between " + min + " and " + max + ": ");
        number = Convert.ToInt32(Console.ReadLine());
    }

    return number;
}