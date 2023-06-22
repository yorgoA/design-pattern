using System;

public class AdidasShoe : Shoe
{
    public AdidasShoe(double price, string theme) : base(price, "Adidas", theme)
    {
    }

    public override bool IsValid()
    {
        return price >= 60 && price <= 250;
    }

    public override void Pay()
    {
        Console.WriteLine($"Paiement effectué pour les chaussures Adidas, prix: {price}, thème: {theme}");
    }
}
