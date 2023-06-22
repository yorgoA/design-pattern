using System;

public class ShoeFactory
{
    public Shoe GetShoe(string shoeBrand, string theme)
    {
        switch (shoeBrand)
        {
            case "Nike":
                return new NikeShoe(200, theme);
            case "Adidas":
                return new AdidasShoe(100, theme); 
            default:
                throw new Exception($"Invalid shoe brand: {shoeBrand}");
        }
    }
}
