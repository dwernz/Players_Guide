using System;

// Challenge: The Triangle Farmer

Console.Write("Base: ");
string baseOfTriangleString = Console.ReadLine();
Console.Write("Height: ");
string heightOfTrianleString = Console.ReadLine();

double baseOfTriangle = Convert.ToDouble(baseOfTriangleString);
double heightOfTriangle = Convert.ToDouble(heightOfTrianleString);

double areaOfTriangle = (baseOfTriangle * heightOfTriangle) / 2;

Console.WriteLine("Area of Triangle: " + areaOfTriangle);