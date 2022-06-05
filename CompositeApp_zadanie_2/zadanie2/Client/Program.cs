// See https://aka.ms/new-console-template for more information

using Domain;

// Główny BOX
var box = new BoxComposite("Box", 0);

// zawartość bezpośrednia
var chargingCable = new ItemLeaf("Kabel do ładowania", 50);
var earbuds = new ItemLeaf("AirPods", 999);
var phone = new ItemLeaf("iPhone 13 Pro", 4500);

box.Add(chargingCable);
box.Add(earbuds);
box.Add(phone);

// mniejszy BOX w śrdoku
var boxInside = new BoxComposite("Paczka z akcesoriami", 0);

// zawartość mniejszego BOXa
var screenGlass = new ItemLeaf("Szkło na ekran", 99);
var phoneCase = new ItemLeaf("Etui na telefon", 250);

boxInside.Add(screenGlass);
boxInside.Add(phoneCase);

box.Add(boxInside);

Console.WriteLine("Suma: " +  box.CalculateTotal());
