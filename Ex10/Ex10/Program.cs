using Ex10;

Console.WriteLine("Enter the student data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Grade1: ");
double grade1 = double.Parse(Console.ReadLine());
Console.Write("Grade2: ");
double grade2 = double.Parse(Console.ReadLine());
Console.Write("Grade3: ");
double grade3 = double.Parse(Console.ReadLine());

Student s = new Student(name, grade1, grade2, grade3);

Console.WriteLine(s);