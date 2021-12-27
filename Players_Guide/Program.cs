using System;

Console.WriteLine("What kind of thing are we talking about?");
// Name of object
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// Description of the object
string b = Console.ReadLine();
// String Doom
string c = "Doom";
// String version
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");