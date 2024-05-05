using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escriba primera nota: ");
        double primeraNota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escriba  segunda nota: ");
        double segundaNota = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Escriba tercera nota: ");
        double terceraNota = Convert.ToDouble(Console.ReadLine());

        double promedio = (primeraNota + segundaNota + terceraNota) / 3;

        if (promedio >= 7)
        {
            Console.WriteLine("Promocionado");
        }
        else if (promedio >= 4 && promedio < 7)
        {
            Console.WriteLine("Regular");
        }
        else
        {
            Console.WriteLine("Reprobado");
        }
    }
}
