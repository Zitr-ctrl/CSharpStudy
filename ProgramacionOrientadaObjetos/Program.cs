
using ProgramacionOrientadaObjetos.Business;

Beer erdingerBeer = new Beer("Erdinger", 10, -9);
//var coronaBeer = new Beer("Corona", 15);
ExpiringBeer delirium = new ExpiringBeer("Delirium", 25, 30, new DateTime(2029, 12, 23));

//Console.WriteLine($"{coronaBeer.Name} tiene un precio de {coronaBeer.Price}");
Console.WriteLine(erdingerBeer.GetInfo());
Console.WriteLine(delirium.GetInfo());
Console.WriteLine(delirium.GetInfo("Una cerveza que caduca: "));
Console.WriteLine(delirium.GetInfo(1207695030));