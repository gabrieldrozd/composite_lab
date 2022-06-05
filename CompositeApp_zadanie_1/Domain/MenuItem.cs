namespace Domain;

public class MenuItem : Menu
{
    public MenuItem(string url, string name) : base(url, name)
    {
    }

    public override void DisplayMenu()
    {
        Console.WriteLine($"{GetName()} {GetUrl()}");
    }
}