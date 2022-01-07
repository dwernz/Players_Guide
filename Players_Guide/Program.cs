using System;

// Challenge: Simula's Soups

// Set Console attributes
Console.Title = "Simula's Soups";
Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;

Console.Clear();

(SoupType type, MainIngredient ingredient, Seasoning seasoning)[] soups = new (SoupType, MainIngredient, Seasoning)[3];

for (int index = 0; index < soups.Length; index++)
{
    soups[index] = GetSoup();
}

foreach (var soup in soups)
{
    Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");
}

(SoupType, MainIngredient, Seasoning) GetSoup()
{
    SoupType type = GetSoupType();
    MainIngredient ingredient = GetMainIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredient, seasoning);
}

SoupType GetSoupType()
{
    Console.Write("Soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine();
    return input switch
    {
        "soup" => SoupType.Soup,
        "stew" => SoupType.Stew,
        "gumbo" => SoupType.Gumbo
    };
}

MainIngredient GetMainIngredient()
{
    Console.Write("Main ingredient (mushroom, chicken, carrot, potato): ");
    string input = Console.ReadLine();
    return input switch
    {
        "mushroom" => MainIngredient.Mushrooms,
        "chicken" => MainIngredient.Chicken,
        "carrot" => MainIngredient.Carrots,
        "potato" => MainIngredient.Potatoes
    };
}

Seasoning GetSeasoning()
{
    Console.Write("Seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.Spicy,
        "salty" => Seasoning.Salty,
        "sweet" => Seasoning.Sweet
    };
}

enum SoupType { Soup, Stew, Gumbo};
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes};
enum Seasoning { Spicy, Salty, Sweet};