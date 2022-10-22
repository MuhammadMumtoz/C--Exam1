public class Person
{
    public string Name {get; set;}
    public string Surname {get; set;}
    public int Age {get; set;}
    public string GetInfo()
    {
        return $"Hello! My name is {Name} {Surname}";
    }
}
