using System;

public class AdidasCustomer : Customer
{
    protected override Shoe CreateShoe(double price, string theme)
    {
        return new AdidasShoe(price, theme);
    }
}
