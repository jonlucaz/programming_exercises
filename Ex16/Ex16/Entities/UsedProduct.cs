using System;
using System.Globalization;
namespace Ex16.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufatureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufatureDate) : base(name, price)
        {
            ManufatureDate = manufatureDate;
        }


        public override string PriceTag()
        {
            return Name
                + " - (used) $"
                + Price.ToString(CultureInfo.InvariantCulture)
                + "\n(Manufacture Data: "
                + ManufatureDate.ToString("dd/MM/yyyy")
                + ")";
        }
    }
}
