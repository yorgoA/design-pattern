using System.Collections.Generic;
using System;

public class Shoe : IShoeComponent
{
    private List<IShoeComponent> components = new List<IShoeComponent>();
    public string Name { get; private set; }

    public Shoe(string name)
    {
        Name = name;
    }

    public void AddComponent(IShoeComponent component)
    {
        components.Add(component);
    }

    public double GetPrice()
    {
        double total = 0;
        foreach (var component in components)
        {
            total += component.GetPrice();
        }
        return total;
    }

    public string GetName()
    {
        return Name;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{GetName()} shoe details:");
        foreach (var component in components)
        {
            component.DisplayDetails();
        }
        Console.WriteLine($"Total Price for {GetName()}: {GetPrice()}");
    }
}
