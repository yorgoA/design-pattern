using System.Linq;
using System;

public class AdidasHandler : AbstractHandler
{
    public override bool Handle(string request)
    {
        var allowedThemes = new[] { "basketball", "food" };

        if (allowedThemes.Contains(request))
        {
            Console.WriteLine($"Adidas shoes are available with {request} theme");
            return true;
        }
        else
        {
            return base.Handle(request);
        }
    }
}
