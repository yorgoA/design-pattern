using System;

public class Theme : ShoeComponent
{
    public Theme(string theme) 
        : base(0, theme) 
    {
    }
    
    public override void DisplayDetails()
    {
        Console.WriteLine($"Theme: {GetName()}");
    }
}
