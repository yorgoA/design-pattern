using System;

public class ShoeFactory
{
    public Shoe GetShoe(string shoeBrand, string theme)
    {
        switch (shoeBrand)
        {
            case "Nike":
                return new NikeShoe(200, theme); // fixed price of 200 for Nike
            case "Adidas":
                return new AdidasShoe(100, theme); // fixed price of 100 for Adidas
            default:
                throw new Exception($"Invalid shoe brand: {shoeBrand}");
        }
    }
}
