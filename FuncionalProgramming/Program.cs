//Console.WriteLine(Tomorrow());
//Console.WriteLine(TomorrowPure(new DateTime(2026, 06, 24, 0, 0, 0)));

// Funciones de primera clase
// Tienen la peculiaridad de que se pueden guardar en una variable
var t = TomorrowPure;
Console.WriteLine(t(new DateTime(2026, 06, 24, 0, 0, 0)));

var beer = new Beer()
{
    Name = "Heineken"
};

Console.WriteLine(ToUpper(beer).Name);
Console.WriteLine(beer.Name);


// Un Action es un delegado predefinido que representa una referencia a un
// método que no devuelve ningún valor (void).
Action<string> Show = Console.WriteLine;
Show("Hola Mundo");

// Expresiones lambdas vendrian a ser funciones flecha

Action<string> Hi = name => Console.WriteLine($"Hola me llamo {name}");
Hi("Josue");

Action<int, int> Add = (num1, num2) => Show($"El resultado es: {num1 + num2}");
Add(7, 8);

// Metodos FUNC
Func<int, int, int> Mul = (a, b) => a * b;
Show(Mul(3,4).ToString());

Func<int, int, string> MulString = (a, b) =>
{
    var res = a * b;
    return res.ToString();
};

Show(MulString(3,4).ToString());

// Funcion no pura
DateTime Tomorrow()
{
    return DateTime.Now.AddDays(1);
}

// Funcion Pura
DateTime TomorrowPure(DateTime date)
{
    return date.AddDays(1);
}

// Esta funcion no es pura debido a que modifica el comportamiento de la clase Beer
Beer ToUpper(Beer beer)
{
    beer.Name = beer.Name.ToUpper();
    return beer;
}

Beer ToUpperPure(Beer beer)
{
    var beer2 = new Beer()
    {
        Name = beer.Name.ToUpper()
    };

    return beer2;
}

public class Beer
{
    public string Name { get; set; }
}

