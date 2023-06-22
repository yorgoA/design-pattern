public class NikeShoeBuilder : IShoeBuilder
{
    private double _price;
    private string _brand;
    private string _theme;

    public void SetPrice(double price)
    {
        _price = price;
    }

    public void SetBrand(string brand)
    {
        _brand = brand;
    }

    public void SetTheme(string theme)
    {
        _theme = theme;
    }

    public Shoe Build()
    {
        return new Shoe(_price, _brand, _theme);
    }
}
