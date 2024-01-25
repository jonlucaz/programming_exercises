using System.Globalization;

namespace Ex07
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue()
        {
            return Quantity * Price;
        }

        public void AddProduct (int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProduct (int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " units"
                + ", Total: $"
                + TotalValue().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
