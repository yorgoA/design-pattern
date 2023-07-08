using System;
using System.Collections.Generic;

public class ShoeComponent : IShoeComponent
{
    protected double Price;
    protected string Name;
    private List<IShoeComponent> _components = new List<IShoeComponent>();


    public ShoeComponent(double price, string name)
    {
        Price = price;
        Name = name;
    }

    public virtual double GetPrice()
    {
        return Price;
    }

    public virtual string GetName()
    {
        return Name;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Component: {GetName()}, Prix: {GetPrice()}");
    }
    public void AddComponent(IShoeComponent component)
    {
        _components.Add(component);
    }
}
