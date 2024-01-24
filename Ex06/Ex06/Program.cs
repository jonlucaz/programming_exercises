using Ex06;
using System.Globalization;

string name = Console.ReadLine();
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Employee emp1 = new Employee(name, salary);

string name2 = Console.ReadLine();
double salary2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Employee emp2 = new Employee(name2, salary2);


double AvgSalary(double s1, double s2)
{
    return (s1 + s2) / 2;
}

Console.WriteLine("Average salary = " + AvgSalary(salary, salary2).ToString("F2"), CultureInfo.InvariantCulture);




