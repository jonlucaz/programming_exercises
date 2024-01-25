using System.Globalization;

namespace Ex09
{
    internal class Employee
    {
        public string Name { get; set; }
        public double GrossSalary { get; set; }
        public double Tax { get; set; }

        public Employee(string name, double grossSalary, double tax)
        {
            Name = name;
            GrossSalary = grossSalary;
            Tax = tax;
        }

        public void IncreaseSalary(double percent)
        {
            GrossSalary = GrossSalary + (GrossSalary * percent / 100);
        }

        public double FinalSalary()
        {
            return GrossSalary - Tax;
        }




        public override string ToString()
        {
            return Name
                + ", Salary: $"
                + FinalSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
