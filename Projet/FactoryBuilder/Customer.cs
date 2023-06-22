using System.Collections.Generic;

public abstract class Customer
{
    protected IList<Shoe> shoes = new List<Shoe>();

    public IList<Shoe> Shoes => shoes;

    protected abstract Shoe CreateShoe(double price, string theme);

    public void NewOrder(double price, string theme)
    {
        Shoe shoe = this.CreateShoe(price, theme);
        if (shoe.IsValid())
        {
            shoe.Pay();
            shoes.Add(shoe);
        }
    }
}
