using System;

// Challenge: The Prototype

Console.Title = "The Prototype";

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

int tries = 1;

Console.Write("Enter a number between 0 and 100: ");
int guess = Convert.ToInt32(Console.ReadLine());

Random randomNumber = new Random();
int number = randomNumber.Next(0, 100);

bool isCorrect = false;

while (!isCorrect)
{
    if (number == guess)
    {
        isCorrect = true;
        break;
    }
    else if (number > guess)
    {
        Console.WriteLine(guess + " is too low");
    }
    else if (number < guess)
    {
        Console.WriteLine(guess + " is too high");
    }

    tries++;

    Console.WriteLine("What is your next guess? ");
    guess = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("You guessed the number, "+ number +"! It took " + tries + " tries.");