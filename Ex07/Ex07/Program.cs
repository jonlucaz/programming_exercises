using Ex07;

Console.WriteLine("Enter the product data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Price: ");
double price = double.Parse(Console.ReadLine());
Console.Write("Quantity: ");
int quantity = int.Parse(Console.ReadLine());

Product p = new Product(name, price, quantity);

Console.WriteLine("Product Data: " + p);

Console.WriteLine("Enter the product quantity to add to stock: ");
quantity = int.Parse(Console.ReadLine());
p.AddProduct(quantity);

Console.WriteLine("Updated product data: " + p);

Console.WriteLine("Enter the product quantity to remove from stock: ");
quantity = int.Parse(Console.ReadLine());
p.RemoveProduct(quantity);

Console.WriteLine("Updated product data: " + p);