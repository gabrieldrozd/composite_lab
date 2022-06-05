// See https://aka.ms/new-console-template for more information

using Domain;

var szef = new Kierownik("Szef");
var kierownik = new Kierownik("Kierownik");
kierownik.Add(new Pracownik("pracuś 1"));
kierownik.Add(new Pracownik("pracuś 2"));
kierownik.Add(new Pracownik("pracuś 3"));

var kierownik2 = new Kierownik("Kierownik 2");
kierownik2.Add(new Pracownik("pracuś 4"));
kierownik2.Add(new Pracownik("pracuś 5"));
kierownik2.Add(new Pracownik("pracuś 6"));

szef.Add(kierownik);
szef.Add(kierownik2);

szef.Add(new Pracownik("Podwładny"));


Console.WriteLine($"{szef.GetName()} odpowiada za: {szef.Count()} pracowników");
szef.Display(1);
Console.WriteLine(szef.Count());



