namespace Domain;

public interface IPackageComponentOperations
{
    void Add(PackageComponent component);
    void Remove(PackageComponent component);
}