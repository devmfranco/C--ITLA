using System;

class Program
{
    static void Main()
    {
        
        Console.WriteLine("Ingresar 4 numeros:");

        Console.Write("Primer numero: ");
        double primerNumero = double.Parse(Console.ReadLine());

        Console.Write("Segundo numero: ");
        double segundoNumero = double.Parse(Console.ReadLine());

        Console.Write("Tercer numero: ");
        double tercerNumero = double.Parse(Console.ReadLine());

        Console.Write("Cuarto numero: ");
        double cuartoNumero = double.Parse(Console.ReadLine());

        //Suma de primer y segundo numero
        double suma = primerNumero + segundoNumero;

        // Producto del tercer y cuarto numero
        double producto = tercerNumero * cuartoNumero;


        Console.WriteLine($"La suma de los dos primeros numeros es: {suma}");
        Console.WriteLine($"El producto del tercer y cuarto numero es: {producto}");
    }
}
