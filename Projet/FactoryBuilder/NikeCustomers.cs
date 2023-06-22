using System;

public class NikeCustomer : Customer
{
    protected override Shoe CreateShoe(double price, string theme)
    {
        return new NikeShoe(price, theme);
    }
}
