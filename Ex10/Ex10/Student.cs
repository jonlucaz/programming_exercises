using System.Globalization;

namespace Ex10
{
    internal class Student
    {
        public string Name { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }

        public Student(string name, double nota1, double nota2, double nota3)
        {
            Name = name;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double TotalGrade()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Aproved()
        {
            if (TotalGrade() > 60) { 
                return "Aproved";
            }
            else
            {
                return "Reproved";
            }
        }

        public override string ToString()
        {
            return Name
                + ", Total Grade: "
                + TotalGrade().ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Aproved();
        }
    }
}
