using System;

public class Program
{
    public static void Main(string[] args)
    {
        const double nikePrice = 200;
        const double adidasPrice = 100;

        Console.WriteLine("Veuillez choisir une marque de chaussures (Nike / Adidas):");
        string brand = Console.ReadLine();

        Console.WriteLine("Veuillez choisir un thème (manga, anime, soccer, basketball, food):");
        string theme = Console.ReadLine();

        Customer customer;
        double price;
        try
        {
            if (brand.Equals("Nike", StringComparison.OrdinalIgnoreCase))
            {
                customer = new NikeCustomer();
                price = nikePrice;
            }
            else if (brand.Equals("Adidas", StringComparison.OrdinalIgnoreCase))
            {
                customer = new AdidasCustomer();
                price = adidasPrice;
            }
            else
            {
                Console.WriteLine("Marque invalide.");
                return;
            }

            customer.NewOrder(price, theme);

            foreach (Shoe shoe in customer.Shoes)
            {
                Console.WriteLine($"Marque: {shoe.Brand}, Prix: {shoe.Price}, Thème: {shoe.Theme}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Une erreur s'est produite : " + ex.Message);
        }
    }
}
