using System.Globalization;

namespace Ex08
{
    internal class Rectangle1
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Rectangle1(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Area()
        {
            return Height * Width;
        }

        public double Perimeter()
        {
            return (Height + Width) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(((Perimeter()*Perimeter()) - 8 * Area())) / 2;
        }

        public override string ToString()
        {
            return "Area: "
                + Area().ToString("F1", CultureInfo.InvariantCulture)
            + "\n Perimeter: "
                + Perimeter().ToString("F1", CultureInfo.InvariantCulture)
            + "\n Diagonal: "
                + Diagonal().ToString("F1", CultureInfo.InvariantCulture);
        }
    }
}
