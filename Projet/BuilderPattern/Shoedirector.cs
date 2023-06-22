public class ShoeDirector
{
    private IShoeBuilder _builder;

    public ShoeDirector(IShoeBuilder builder)
    {
        _builder = builder;
    }

    public void ConstructShoe(double price, string theme)
    {
        _builder.SetPrice(price);
        _builder.SetBrand("Nike"); // Default brand is Nike
        _builder.SetTheme(theme);
    }
}
