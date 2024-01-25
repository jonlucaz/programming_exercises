using Ex13;
using System.Collections.Generic;
using System.Globalization;


Console.WriteLine("How many employees will be registered: ");
int n = int.Parse(Console.ReadLine());

List<Employee> list = new List<Employee>(); 

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Employee #{i + 1} data: ");
    Console.Write("Id: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Salary: ");
    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    list.Add(new Employee(id, name, salary));
    Console.WriteLine();
}


Console.Write("Enter the id that will be salary increase: ");
int searchId = int.Parse(Console.ReadLine());

Employee emp = list.Find(x => x.Id == searchId);

if(!(emp == null))
{
    Console.Write("Enter the percentage: ");
    double percentage = double.Parse(Console.ReadLine());

    emp.IncreaseSalary(percentage);
}
else
{
    Console.WriteLine("This id does not exist!");
}

Console.WriteLine();
Console.WriteLine("Updated data: ");
foreach(Employee obj in list)
{
    Console.WriteLine(obj);
}