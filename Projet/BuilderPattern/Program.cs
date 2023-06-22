using System;

public class Program
{
    public static void Main(string[] args)
    {
        Store store = new Store();
        IShoeBuilder nikeBuilder = new NikeShoeBuilder();
        IShoeBuilder adidasBuilder = new AdidasShoeBuilder();

        Console.WriteLine("Veuillez choisir une marque de chaussures (Nike / Adidas):");
        string brand = Console.ReadLine();

        Console.WriteLine("Veuillez choisir un thème (manga , anime , soccer, basketball or food");
        string theme = Console.ReadLine();
    }
}
