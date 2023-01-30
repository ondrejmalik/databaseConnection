// See https://aka.ms/new-console-template for more information
using ConsoleApp4;

Console.WriteLine("Hello, World!");
database d = new database();
Auto a = new Auto("Škoda", 39);
d.SaveData(a);
d.LoadData();
Auto loadedAuto = d.LoadId(3);
List<Auto> ListAut = d.LoadAll(3);
Console.WriteLine();