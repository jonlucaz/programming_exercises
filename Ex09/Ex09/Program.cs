using Ex09;

Console.WriteLine("Enter the employee data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Salary: ");
double salary = double.Parse(Console.ReadLine());
Console.Write("Tax: ");
double tax = double.Parse(Console.ReadLine());

Employee p = new Employee(name, salary, tax);
Console.WriteLine("Employee: " + p);

Console.WriteLine("Enter the percentage to increase salary: ");
double percent = double.Parse(Console.ReadLine());
p.IncreaseSalary(percent);

Console.WriteLine("Updated data: " + p);


