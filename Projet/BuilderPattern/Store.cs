using System;

public class Store
{
    public void OrderShoe(IShoeBuilder builder, double price, string theme)
    {
        ShoeDirector director = new ShoeDirector(builder);
        director.ConstructShoe(price, theme);
        Shoe shoe = builder.Build();

        shoe.DisplayDetails();
    }
}
