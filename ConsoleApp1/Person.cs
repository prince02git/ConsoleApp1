using System;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }

    //Default contructor
    public Person()
    {
        Name = "Prince";
        Id = 1;
    }
    //Parameterized constructor
    public Person(int id, string name)
    {
        Name =name;
        Id =id; 
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}");
    }
}

class Constructor
{
    static void Main()
    {
        Person person = new Person();
        person.DisplayInfo();

        Person person1 = new Person(4, "prince");
        person1.DisplayInfo();
    }
}