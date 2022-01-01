using System;

// Challenge: Watchtower

Console.Title = "Watchtower";

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

Console.Write("Enter X coordinate: ");
string xString = Console.ReadLine();

Console.Write("Enter Y coordinate: ");
string yString = Console.ReadLine();

int x = Convert.ToInt32(xString);
int y = Convert.ToInt32(yString);

string direction = "";

// determine the direction of the enemy
if (x < 0)
{
    if (y > 0)
    {
        direction = "NW";
    }
    else if (y == 0)
    {
        direction = "W";
    }
    else if (y < 0)
    {
        direction = "SW";
    }
}
else if (x == 0)
{
    if (y > 0)
    {
        direction = "N";
    }
    else if (y == 0)
    {
        direction = "!";
    }
    else if (y < 0)
    {
        direction = "S";
    }
}
else if (x > 0)
{
    if (y > 0)
    {
        direction = "NE";
    }
    else if (y == 0)
    {
        direction = "E";
    }
    else if (y < 0)
    {
        direction = "SE";
    }
}

// Output message of where the enemy is
if (direction != "!")
{
    Console.WriteLine("The enemy is to the " + direction + "!");
}
else
{
    Console.WriteLine("The enemy is here!");
}