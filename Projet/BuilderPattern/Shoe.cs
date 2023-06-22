using System;

public class Shoe
{
    public double Price { get; }
    public string Brand { get; }
    public string Theme { get; }

    public Shoe(double price, string brand, string theme)
    {
        Price = price;
        Brand = brand;
        Theme = theme;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Marque: {Brand}, Prix: {Price}, Thème: {Theme}");
    }
}
