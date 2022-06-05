namespace Domain;

/// <summary>
/// Component
/// </summary>
public abstract class PracownikAbs
{
    protected PracownikAbs(string name)
    {
        Name = name;
    }

    protected string Name { get; }

    public abstract int Count();
    public abstract void Display(int depth);
    public abstract string GetName();
    public abstract void Add(PracownikAbs pracownik);
}