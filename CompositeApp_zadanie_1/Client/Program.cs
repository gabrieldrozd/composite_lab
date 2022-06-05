// See https://aka.ms/new-console-template for more information

using Domain;

var menuItem = new MenuItem("testUrl", "test");
menuItem.DisplayMenu();

var menuComp = new Menu(menuItem.GetUrl(), menuItem.GetName());

menuComp.Add(new MenuComponent("2", "2"));
menuComp.Add(new MenuComponent("3", "3"));
menuComp.Add(new MenuComponent("4", "4"));

menuComp.DisplayMenu();
