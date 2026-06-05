
using ProgramacionOrientadaObjetos.Business;

Beer erdingerBeer = new Beer("Erdinger", 10, -9);
//var coronaBeer = new Beer("Corona", 15);
ExpiringBeer delirium = new ExpiringBeer("Delirium", 25, 30, new DateTime(2029, 12, 23));

//Console.WriteLine($"{coronaBeer.Name} tiene un precio de {coronaBeer.Price}");
Console.WriteLine(erdingerBeer.getInfo());
Console.WriteLine(delirium.getInfo());
