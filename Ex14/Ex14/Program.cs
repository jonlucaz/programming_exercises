using Ex14.Entities;
using Ex14.Entities.Enums;
using System.Globalization;

Console.Write("Enter department's name: ");
string departmentName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string workerName = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkLevel level = Enum.Parse<WorkLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(departmentName);
Worker worker = new Worker(workerName, level, dept, baseSalary);

Console.Write("How many contracts to this worker: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Enter #{i+1} contract data: ");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine());
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY): ");
string[] monthAndYear = Console.ReadLine().Split("/");

int month = int.Parse(monthAndYear[0]);
int year = int.Parse(monthAndYear[1]);

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));


