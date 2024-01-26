using Ex16.Entities;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write("Common, used or imported (c/u/i)? ");
    char resp = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


    if (resp == 'c')
    {
        list.Add(new Product(name, price));
    }
    else if (resp == 'u')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, date));
    }
    else
    {
        Console.WriteLine("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new ImportedProduct(name, price, customFee));
    }
}

Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product product in list)
{
    Console.WriteLine(product.PriceTag());
}