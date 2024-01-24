using Ex05;



Person p1 = new Person();
Person p2 = new Person();

p1.Name = "Maria";
p1.Age = 17;

p2.Name = "Joao";
p2.Age = 16;

if(p1.Age > p2.Age)
{
    Console.WriteLine("Maria");
}
else
{
    Console.WriteLine("Joao"); 
}
