using System.Linq;
using System;

public class NikeHandler : AbstractHandler
{
    public override bool Handle(string request)
    {
        var allowedThemes = new[] { "manga", "anime", "soccer" };

        if (allowedThemes.Contains(request))
        {
            Console.WriteLine($"Nike shoes are available with {request} theme");
            return true;
        }
        else
        {
            return base.Handle(request);
        }
    }
}
