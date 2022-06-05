namespace Domain;

public class ItemLeaf : PackageComponent
{
    public ItemLeaf(string name, int price) : base(name, price)
    {
    }

    public override int CalculateTotal()
    {
        Console.WriteLine($"{_name} with the price {_price}");

        return _price;
    }
}