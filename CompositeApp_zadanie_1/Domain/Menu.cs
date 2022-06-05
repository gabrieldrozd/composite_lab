namespace Domain;

public class Menu : MenuComponent
{
    public Menu(string url, string name) : base(url, name)
    {
    }

    private List<MenuComponent> SubMenus { get; set; } = new();

    public override void Add(MenuComponent component)
    {
        SubMenus.Add(component);
    }

    public override void DisplayMenu()
    {
        foreach (var menu in SubMenus)
        {
            Console.WriteLine($"{menu.GetName()} {menu.GetUrl()}");
        }
    }
}