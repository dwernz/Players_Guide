using System;

// Challenge: Buying Inventory

Console.Title = "Buying Inventory";

Console.BackgroundColor = ConsoleColor.Blue;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
Console.Write("What number do you want to see the price of? ");

string choiceString = Console.ReadLine();
int choice = Convert.ToInt32(choiceString);

string itemName = "";
int price = 0;

switch (choice)
{
    case 1:
        itemName = "Rope";
        price = 10;
        break;
    case 2:
        itemName = "Torches";
        price = 15;
        break;
    case 3:
        itemName = "Climbing Equipment";
        price = 25;
        break;
    case 4:
        itemName = "Clean Water";
        price = 1;
        break;
    case 5:
        itemName = "Machete";
        price = 20;
        break;
    case 6:
        itemName = "Canoe";
        price = 200;
        break;
    case 7:
        itemName = "Food Supplies";
        price = 1;
        break;
    default:
        Console.WriteLine("Item not found");
        break;
}

Console.WriteLine(itemName + " costs " + price + " gold.");