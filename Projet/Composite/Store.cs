using System;
public class Store
{
    public void OrderShoe(IShoeComponent shoe)
    {
        shoe.DisplayDetails();
    }
}
