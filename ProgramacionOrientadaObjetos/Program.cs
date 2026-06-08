
using ProgramacionOrientadaObjetos.Business;
using ProgramacionOrientadaObjetos.Class;

//Beer erdingerBeer = new Beer("Erdinger", 10, -9, 1000);
////var coronaBeer = new Beer("Corona", 15);
//ExpiringBeer delirium = new ExpiringBeer("Delirium", 25, 30, new DateTime(2029, 12, 23), 250);

////Console.WriteLine($"{coronaBeer.Name} tiene un precio de {coronaBeer.Price}");
//Console.WriteLine(erdingerBeer.GetInfo());
//Console.WriteLine(delirium.GetInfo());
//Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
//Console.WriteLine(delirium.GetInfo(1207695030));
//Console.WriteLine(delirium.GetCategory());

//Animal benji = new Animal("Benji", 7, 63);
//Drink vino = new Wine(600);
//Console.WriteLine(benji.getInfo());
//Console.WriteLine(vino.GetQuantity());
//Console.WriteLine(vino.GetCategory());

Animal benji = new Perro("Benji", 8, 63, "perro cruzado");
Console.WriteLine(benji.getInfo());
Console.WriteLine(benji.Sound());
Console.WriteLine(benji.Tipo());


var elements = new Colletion<int>(3);
elements.Add(100);
elements.Add(150);
elements.Add(200);
elements.Add(500);  

foreach (var element in elements.Get())
{
    Console.WriteLine(element);
}

var names = new Colletion<string>(2);
names.Add("Josue");
names.Add("Jennifer");
names.Add("Erick");

foreach (var name in names.Get())
{
    Console.WriteLine(name);
}