using System;

// Boss Battle: Hunting the Manticore


// Set Console attributes
Console.Title = "Hunting the Manticore";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();


bool isManticoreDefeated = false;
bool isCityDestroyed = false;

int round = 1;
int cityHealth = 15;
int manticoreHealth = 10;
int cannonDamage = 1;
int aim = 0;

Console.WriteLine("Player 1, how far away from the city do you want to station the Manticore? (1-100)");
int manticoreDistance = Convert.ToInt32(Console.ReadLine());

while (manticoreDistance > 100 || manticoreDistance < 1)
{
    Console.Write("Invalid range, please enter a number between 1 and 100: ");
    manticoreDistance = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
}

Console.Clear();

Console.WriteLine("Player 2, it is your turn");



while (!isManticoreDefeated && !isCityDestroyed) 
{
    DisplayStatus(); 
}

if (isManticoreDefeated)
{
    Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!");
}

if (isCityDestroyed)
{
    Console.WriteLine("You failed to stop the Manticore. The city of Consolas has been destroyed");
}

void DisplayStatus()
{
    if (round % 3 == 0 && round % 5 == 0)
    {
        cannonDamage = 10;
    }
    else if (round % 3 == 0)
    {
        cannonDamage = 3;
    }
    else if (round % 5 == 0)
    {
        cannonDamage = 5;
    }
    else
    {
        cannonDamage = 1;
    }
    
    Console.WriteLine("STATUS: Round: " + round + " City: " + cityHealth + "/15 Manticore: " + manticoreHealth + "/10");
    Console.WriteLine("The cannon is expected to deal " + cannonDamage + " damage this round.");
    Console.Write("Enter the desired cannon range: ");
    aim = Convert.ToInt32(Console.ReadLine());

    if (aim == manticoreDistance)
    {
        manticoreHealth -= cannonDamage;
        Console.WriteLine("That round was a DIRECT HIT!");
        Console.WriteLine();
        if (manticoreHealth <= 0)
        {
            isManticoreDefeated = true;
            return;
        }

        manticoreDistance = 0;
        
        Console.Write("Player 1, move the Manticore! (1-100): ");
        while (manticoreDistance > 100 || manticoreDistance < 1)
        {
            Console.Write("Invalid range, please enter a number between 1 and 100: "); ;
            manticoreDistance = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
        }
    }
    else if (aim > manticoreDistance)
    {
        Console.WriteLine("That round OVERSHOT the target.\n\n");
    }
    else if (aim < manticoreDistance)
    {
        Console.WriteLine("That round FELL SHORT of the target.\n\n");
    }

    cityHealth--;

    if (cityHealth <= 0)
    {
        isCityDestroyed = true;
        return;
    }

    round++;
}