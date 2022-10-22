
var person1 = new Person();
System.Console.WriteLine("Person 1:");
System.Console.Write("Name: ");
person1.Name = Console.ReadLine();
System.Console.Write("Surname: ");
person1.Surname = Console.ReadLine();
System.Console.Write("Age: ");
person1.Age = Convert.ToInt32(Console.ReadLine());
var person2 = new Person();
System.Console.WriteLine("Person 2:");
System.Console.Write("Name: ");
person2.Name = Console.ReadLine();
System.Console.Write("Surname: ");
person2.Surname = Console.ReadLine();
System.Console.Write("Age: ");
person2.Age = Convert.ToInt32(Console.ReadLine());
var person3 = new Person();
System.Console.WriteLine("Person 3:");
System.Console.Write("Name: ");
person3.Name = Console.ReadLine();
System.Console.Write("Surname: ");
person3.Surname = Console.ReadLine();
System.Console.Write("Age: ");
person3.Age = Convert.ToInt32(Console.ReadLine());
// list<Person> Persons = new list<Person>();
Person[] Persons = new Person[3];
Persons[0] = person1;
Persons[1] = person2;
Persons[2] = person3;

foreach(var item in Persons)
{
    System.Console.WriteLine(item.GetInfo());
}
