using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la primera nota: ");
        double primeraNota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la segunda nota: ");
        double segundaNota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la tercera nota: ");
        double terceraNota = Convert.ToDouble(Console.ReadLine());

        double promedio = (primeraNota + segundaNota + terceraNota / 3);

        if (promedio >= 7)
        {
            Console.WriteLine("Promocionado");
        }

        Console.WriteLine();
    }
}
