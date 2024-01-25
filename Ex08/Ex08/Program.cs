using Ex08;
using System.Globalization;

Console.WriteLine("Enter height and width from rectangle: ");
Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());
Console.Write("Width: ");
double width = double.Parse(Console.ReadLine());

Rectangle1 r = new Rectangle1(height, width);

Console.WriteLine(r);

