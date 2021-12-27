using System;

// Challenge: The Variable Shop

byte shopNumber= 1; //0 - 255
short items = 100; // -32,768 - 32,767
int inventory = 25564; // -2,147,483,648 - 2,147,483,647
long sales = 21512432; // -9,223,372,036,854,775,808 - 9,223,372,036,854,775,807
sbyte salesToday = 34; // -128 - 127
ushort itemsSoldToday = 45234; // 0 - 65,535
uint itemsSold = 45642325; // 0 - 4,294,967,295
ulong itemsAvaliable = 43264235; // 0 - 18,446,744,073,709,551,615

char letter = 'A'; // Single character
string shopName = "The Variable Shop"; // String of text

float revenueToday = 1324.79f; // 7 digits of precision
double revenueYearToDate = 145235214.65; // 15-16 digits of precision
decimal revenueToDate = 4682134934321.54m; // 28-29 digits of precision, more accurate but slower

bool isOpen = true; // True or False

Console.WriteLine("Shop's number: " + shopNumber);
Console.WriteLine("Different items in shop: " + items);
Console.WriteLine("Number of items to sell: " + inventory);
Console.WriteLine("Sales to date: " + sales);
Console.WriteLine("Sales today: " + salesToday);
Console.WriteLine("Items Sold today: " + itemsSoldToday);
Console.WriteLine("Items Sold total: " + itemsSold);
Console.WriteLine("Items in warehouse: " + itemsAvaliable);

Console.WriteLine("Shop's rating: " + letter);
Console.WriteLine("Shop's name: " + shopName);

Console.WriteLine("Revenue today: $" + revenueToday);
Console.WriteLine("Revenue Year to date: $" + revenueYearToDate);
Console.WriteLine("Revenue total: $" + revenueToDate);

Console.WriteLine("Is the shop open? " + (isOpen ? "yes" : "no"));