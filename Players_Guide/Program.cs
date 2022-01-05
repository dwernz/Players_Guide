using System;

// Challenge: Simula's Test

// Define an enumeration for the state of the chest.
// Make a variable whose type is this new enumeration.
// Write code to allow you to manipulate the chest with the lock, unlock, open, and close commands, but ensure that you don't transition between states that don't support it.
// Loop forever, asking fo the next command


// Set Console attributes
Console.Title = "Simula's Test";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

ChestState currentState = ChestState.Locked;

Console.WriteLine("Commands: unlock, open, close, lock\n");

while (true)
{
    Console.Write($"The chest is {currentState}. What do you want to do? ");

    string input = Console.ReadLine();

    if (currentState == ChestState.Locked && input == "unlock")
    {
        currentState = ChestState.Closed;
    }

    if (currentState == ChestState.Closed && input == "open")
    {
        currentState = ChestState.Open;
    }

    if (currentState == ChestState.Closed && input == "lock")
    {
        currentState = ChestState.Locked;
    }

    if (currentState == ChestState.Open && input == "close")
    {
        currentState = ChestState.Closed;
    }
}

enum ChestState { Open, Closed, Locked};