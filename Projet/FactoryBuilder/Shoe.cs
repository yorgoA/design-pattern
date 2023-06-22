using System;

public abstract class Shoe
{
    protected double price;
    protected string brand;
    protected string theme;

    public string Brand => brand;
    public double Price => price;
    public string Theme => theme;

    public Shoe(double price, string brand, string theme)
    {
        this.price = price;
        this.brand = brand;
        this.theme = theme;
    }

    public abstract bool IsValid();

    public abstract void Pay();
}
