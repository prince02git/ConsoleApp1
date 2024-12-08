using System;
using System.ComponentModel;


public class Chaining
{
    public string Name { get; set; }
    public int Age { get; set; }

    //Default Constructor
    public Chaining() : this("Unknown", 0)
    {
        Console.WriteLine("this is the default construcor called");
    }

    public Chaining(string name, int age)
    {
        Name = name;    
        Age = age;
        Console.WriteLine("This is parameterized constructor");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}
