namespace Domain;

public class MenuComponent
{
    public MenuComponent(string url, string name)
    {
        Url = url;
        Name = name;
    }

    private string Url { get; set; }
    private string Name { get; set; }
    
    // Methods
    public string GetUrl()
    {
        return Url;
    }
    
    public string GetName()
    {
        return Name;
    }

    //metoda Add ma być abstract bez implementacji
    public virtual void Add(MenuComponent component)
    {
        throw new NotImplementedException();
    }
    
    //metoda Add ma być abstract bez implementacji
    public virtual void DisplayMenu()
    {
        throw new NotImplementedException();
    }
}