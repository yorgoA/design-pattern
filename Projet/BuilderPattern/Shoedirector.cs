public class ShoeDirector
{
    private IShoeBuilder _builder;

    public ShoeDirector(IShoeBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructShoe(string brand,double price, string theme)
    {
        _builder.SetPrice(price);
        _builder.SetBrand(brand);
        _builder.SetTheme(theme);
    }
}
