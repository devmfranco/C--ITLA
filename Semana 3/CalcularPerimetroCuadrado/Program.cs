using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el valor del lado del cuadrado: ");
        double ladoCuadrado = double.Parse(Console.ReadLine());

        double perimetro = ladoCuadrado * 4;

        // Mostrar el resultado por pantalla
        Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
    }
}
