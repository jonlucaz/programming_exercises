using System.Globalization;

Console.WriteLine("Code   -   Product   -   Price");
Console.WriteLine("1      -   HotDog    -   R$4.00");
Console.WriteLine("2      -   X-Salad   -   R$4.50");
Console.WriteLine("3      -   X-Bacon   -   R$5.00");
Console.WriteLine("4      -   Toast     -   R$2.00");
Console.WriteLine("5      -   Soda      -   R$1.50");


Console.Write("Please enter code and quantity from products do you want: ");
string[] data = Console.ReadLine().Split(' ');

int code = int.Parse(data[0]);
int quantity = int.Parse(data[1], CultureInfo.InvariantCulture);

switch (code)
{
    case 1:
        Console.WriteLine($"You choose {quantity} HotDog(s), total price R${(quantity * 4.00).ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 2:
        Console.WriteLine($"You choose {quantity} X-Salad(s), total price R${(quantity * 4.50).ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 3:
        Console.WriteLine($"You choose {quantity} X-Bacon(s), total price R${(quantity * 5.00).ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 4:
        Console.WriteLine($"You choose {quantity} Toast(s), total price R${(quantity * 2.00).ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    case 5:
        Console.WriteLine($"You choose {quantity} Soda(s), total price R${(quantity * 1.50).ToString("F2", CultureInfo.InvariantCulture)}");
        break;
    default: Console.WriteLine("Error: Invalid value!");
        break;
}



