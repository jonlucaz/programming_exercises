using System.Globalization;

Console.WriteLine("Enter the number from persons: ");
int n = int.Parse(Console.ReadLine());

double[]vect = new double[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter the height from {i + 1} person: ");
    double h1 = double.Parse(Console.ReadLine());
    vect[i] = h1;
}

double sum = 0.0;

foreach (double obj in vect)
{
    sum += obj;
}

double avg = sum/ n;

Console.WriteLine(avg.ToString("F2", CultureInfo.InvariantCulture));