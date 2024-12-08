using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    private string model; // Only accessible within this class
    protected int speed; // Accessible in this class and derived classes
    public string color; // Accessible everywhere

    public Car(string model, int speed, string color)
    {
        this.model = model;
        this.speed = speed;
        this.color = color;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Model: {model}, Speed: {speed}, Color: {color}");
    }
}

public class SportsCar : Car
{
    public SportsCar(string model, int speed, string color) : base(model, speed, color) { }

    public void IncreaseSpeed()
    {
        speed += 50; // Can access protected member
        Console.WriteLine($"New Speed: {speed}");
    }
}

