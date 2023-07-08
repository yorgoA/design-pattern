using System;

public interface IShoeComponent
{
    double GetPrice();
    string GetName();
    void DisplayDetails();
    void AddComponent(IShoeComponent component);
}
