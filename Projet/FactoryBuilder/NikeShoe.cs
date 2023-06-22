using System;

public class NikeShoe : Shoe
{
    public NikeShoe(double price, string theme) : base(price, "Nike", theme)
    {
    }

    public override bool IsValid()
    {
        return price >= 50 && price <= 200;
    }

    public override void Pay()
    {
        Console.WriteLine($"Paiement effectué pour les chaussures Nike, prix: {price}, thème: {theme}");
    }
}
