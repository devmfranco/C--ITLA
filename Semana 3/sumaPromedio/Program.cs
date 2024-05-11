using System;

class Program
{
    static void Main()
    {
     
        Console.WriteLine("Ingresa cuatro valores numéricos:");

        Console.Write("Primer valor: ");
        double primervalor = double.Parse(Console.ReadLine());

        Console. Write("Segundo valor: ");
        double segundoValor= double.Parse(Console.ReadLine());

        Console.Write("Tercer valor: ");
        double tercerValor = double.Parse(Console.ReadLine());

        Console.Write("Cuarto valor: ");
        double cuartoValor = double.Parse(Console.ReadLine());

      
        double suma = primervalor + segundoValor + tercerValor + cuartoValor;

       
        double promedio = suma / 4;

        Console.WriteLine($"La suma de los cuatro valores es: {suma}");
        Console.WriteLine($"El promedio de los cuatro valores es: {promedio}");
    }
}
