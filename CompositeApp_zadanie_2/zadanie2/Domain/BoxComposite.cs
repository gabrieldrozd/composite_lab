namespace Domain;

public class BoxComposite : PackageComponent, IPackageComponentOperations
{
    private readonly List<PackageComponent> _components;

    public BoxComposite(string name, int price) : base(name, price)
    {
        _components = new List<PackageComponent>();
    }

    public override int CalculateTotal()
    {
        var total = 0;

        Console.WriteLine($"{_name} contains the following products with prices");

        foreach (var comp in _components)
        {
            total += comp.CalculateTotal();
        }

        return total;
    }

    public void Add(PackageComponent component)
    {
        _components.Add(component);
    }

    public void Remove(PackageComponent component)
    {
        _components.Remove(component);
    }
}