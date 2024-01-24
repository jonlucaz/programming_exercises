Console.Write("Enter Password: ");
string password = Console.ReadLine();

while (!(password == "2002"))
{
    Console.WriteLine("Wrong Password!");
    password = Console.ReadLine();
}
Console.WriteLine("Access allowed!");