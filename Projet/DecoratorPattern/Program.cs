using System;

public class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store();

        Console.WriteLine("Veuillez choisir une marque de chaussures (Nike / Adidas):");
        string brand = Console.ReadLine();

        Console.WriteLine("Veuillez choisir un thème (manga, anime, soccer, basketball, food):");
        string theme = Console.ReadLine();

        if (brand.ToLower() == "nike")
        {
            IShoe shoe = new NikeShoeDecorator(200, theme);
            store.OrderShoe(shoe);
        }
        else if (brand.ToLower() == "adidas")
        {
            IShoe shoe = new AdidasShoeDecorator(100, theme);
            store.OrderShoe(shoe);
        }
        else
        {
            Console.WriteLine("Marque invalide.");
        }
    }
}
