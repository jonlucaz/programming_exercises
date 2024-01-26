﻿using System;
using System.Globalization;

namespace Ex16.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            return CustomFee + Price;
        }

        public override string PriceTag()
        {
            return Name
                + " - $"
                + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + "\n(Custom Fee: $"
                + CustomFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }
    }
}
