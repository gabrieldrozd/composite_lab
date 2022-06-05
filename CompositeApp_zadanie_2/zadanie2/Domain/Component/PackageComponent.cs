namespace Domain;

public abstract class PackageComponent
{
    protected readonly string _name;
    protected readonly int _price;

    public PackageComponent(string name, int price)
    {
        _name = name;
        _price = price;
    }

    public abstract int CalculateTotal();
}