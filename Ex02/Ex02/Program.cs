using System.Globalization;

double pi = Math.PI;

Console.WriteLine("Enter radius value: ");
double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double area = pi * (radius * radius);

Console.WriteLine("A = " +  area.ToString("F4"), CultureInfo.InvariantCulture);
