using System;

public class Program
{
    public static void Main(string[] args)
    {
        const double NikePrice = 200;
        const double AdidasPrice = 100;

        Console.WriteLine("Veuillez choisir une marque de chaussures (Nike / Adidas):");
        string brand = Console.ReadLine();

        Console.WriteLine("Veuillez choisir un thème (manga, anime, soccer, basketball, food):");
        string theme = Console.ReadLine();

        Customer customer;
        double price;
        if (brand.ToLower() == "nike")
        {
            customer = new NikeCustomer();
            price = NikePrice;
        }
        else if (brand.ToLower() == "adidas")
        {
            customer = new AdidasCustomer();
            price = AdidasPrice;
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
}
