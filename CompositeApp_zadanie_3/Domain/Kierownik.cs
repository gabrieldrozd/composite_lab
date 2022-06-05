namespace Domain;

/// <summary>
/// Composite
/// </summary>
public class Kierownik : PracownikAbs
{
    public Kierownik(string name) : base(name)
    {
        Pracownicy = new List<PracownikAbs>();
    }

    private IList<PracownikAbs> Pracownicy { get; }
    private int DepthCount { get; set; }

    public override string GetName()
    {
        return Name;
    }

    public override void Add(PracownikAbs pracownik)
    {
        Pracownicy.Add(pracownik);
    }

    public override int Count()
    {
        return Pracownicy.Sum(pracownik => pracownik.Count());
    }
    
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + "+" + Name);

        foreach (var pracownik in Pracownicy)
        {
            pracownik.Display(depth + 2);
        }
    }
}