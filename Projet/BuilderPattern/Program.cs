using System;

class Program
{
    static void Main(string[] args)
    {
        Store store = new Store();
        IShoeBuilder nikeBuilder = new NikeShoeBuilder();
        IShoeBuilder adidasBuilder = new AdidasShoeBuilder();

        Console.WriteLine("Veuillez choisir une marque de chaussures (Nike / Adidas):");
        string brand = Console.ReadLine();

        Console.WriteLine("Veuillez choisir un thème (manga , anime , soccer, basketball or food");
        string theme = Console.ReadLine();

        if (brand.ToLower() == "nike")
        {
            nikeBuilder.SetBrand("Nike");
            store.OrderShoe(nikeBuilder,brand, 200, theme); 
        }
        else if (brand.ToLower() == "adidas")
        {
            nikeBuilder.SetBrand("Adidas");
            store.OrderShoe(adidasBuilder, brand,100, theme); 
        }
        else
        {
            Console.WriteLine("Marque de chaussures non reconnue.");
        }
    }
}
