using System;

class Program
{
    static void Main(string[] args)
    {
        int primerNumero, segundoNumero, suma, producto;

        Console.WriteLine("Introduzca el primer numero");
        primerNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca el segundo numero");
        segundoNumero = Convert.ToInt32(Console.ReadLine());


        suma = primerNumero + segundoNumero;
        producto = primerNumero * segundoNumero;

        Console.WriteLine("El resultado de la suma es : " + suma);
        Console.WriteLine("El resultado del producto es: " + producto);


    }
