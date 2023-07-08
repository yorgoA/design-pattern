using System;
public class Store
{
    public void OrderShoe(IShoeBuilder builder,string brand ,double price, string theme)
    {
        ShoeDirector director = new ShoeDirector(builder);
        director.ConstructShoe(brand,price, theme);
        Shoe shoe = builder.Build();

        shoe.DisplayDetails();
    }
}

