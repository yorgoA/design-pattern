using System;

class Program
{
    static void Main(string[] args)
    {
        var nikeHandler = new NikeHandler();
        var adidasHandler = new AdidasHandler();
        nikeHandler.SetNext(adidasHandler);
        
        Console.WriteLine("Enter your preferred theme (manga, anime, soccer, basketball, food):");
        var theme = Console.ReadLine().ToLower();

        bool isAvailable = nikeHandler.Handle(theme);

        if (!isAvailable)
        {
            Console.WriteLine("Would you like to switch brands? (Y/N)");
            var answer = Console.ReadLine().ToUpper();
            if (answer == "Y")
            {
               
                isAvailable = adidasHandler.Handle(theme);
            }
            else
            {
                Console.WriteLine("Thank you for visiting our store. Please come again.");
            }
        }
    }
}
