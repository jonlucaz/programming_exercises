using System.Globalization;

Console.WriteLine("Enter the product 1 data: ");
string[] data1 = Console.ReadLine().Split(' ');

int code = int.Parse(data1[0]);
int quantity = int.Parse(data1[1]);
double price = double.Parse(data1[2]);

double finalPrice1 = quantity * price;

Console.WriteLine("Enter the product 2 data: ");
string[] data2 = Console.ReadLine().Split(' ');

code = int.Parse(data2[0]);
quantity = int.Parse(data2[1]);
price = double.Parse(data2[2]);

double finalPrice2 = quantity * price;

double totalPrice = finalPrice1 + finalPrice2;

Console.WriteLine("Total a pagar R$" + totalPrice.ToString("F2"), CultureInfo.InvariantCulture);