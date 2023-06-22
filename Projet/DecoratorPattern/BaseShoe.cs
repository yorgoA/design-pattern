using System;

public class BaseShoe : IShoe
{
    protected double Price;
    protected string Brand;
    protected string Theme;

    public BaseShoe(double price, string brand, string theme)
    {
        Price = price;
        Brand = brand;
        Theme = theme;
    }

    public virtual double GetPrice()
    {
        return Price;
    }

    public virtual string GetBrand()
    {
        return Brand;
    }

    public virtual string GetTheme()
    {
        return Theme;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Marque: {GetBrand()}, Prix: {GetPrice()}, Thème: {GetTheme()}");
    }
}
