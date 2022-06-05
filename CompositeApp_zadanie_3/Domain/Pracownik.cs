namespace Domain;

/// <summary>
/// Leaf
/// </summary>
public class Pracownik : PracownikAbs
{
    public Pracownik(string name) : base(name)
    {
    }

    public override string GetName()
    {
        return Name;
    }

    public override void Add(PracownikAbs pracownik)
    {
        Console.WriteLine("Nie można dodać do liścia");
    }

    public override int Count()
    {
        return 1;
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}