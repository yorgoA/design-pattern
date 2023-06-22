public interface IShoeBuilder
{
    void SetPrice(double price);
    void SetBrand(string brand);
    void SetTheme(string theme);
    Shoe Build();
}
