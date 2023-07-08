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

        IShoeComponent shoe;
        if (brand.ToLower() == "nike")
        {
            shoe = new Shoe("Nike");
            shoe.AddComponent(new Laces(20));
            shoe.AddComponent(new Fabric(180));
            shoe.AddComponent(new Theme(theme));
        }
        else if (brand.ToLower() == "adidas")
        {
            shoe = new Shoe("Adidas");
            shoe.AddComponent(new Laces(10));
            shoe.AddComponent(new Fabric(90));
            shoe.AddComponent(new Theme(theme));
        }
        else
        {
            Console.WriteLine("Marque de chaussures inconnue. Essayez à nouveau.");
            return;
        }

        store.OrderShoe(shoe);
    }
}
