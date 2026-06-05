Console.WriteLine("Hello, World!");
// variable en C#
int number = 24;
Console.WriteLine($"Mi numero es: {number}");

// Arrays o Listas
int[] numeros = new int[5];
numeros[0] = number;
numeros[1] = 1207695030;
Console.WriteLine(numeros[0]);
Console.WriteLine(numeros[1]);

// Funciones
int resultado = Area(5);
Console.WriteLine($"El el area del cuadrado es: {resultado}");
Show("Josue Ortiz");

int Area(int l)
{
    int result = l * l;
    return result;
}

void Show(string nombre)
{
    Console.WriteLine($"Hola {nombre}");
}