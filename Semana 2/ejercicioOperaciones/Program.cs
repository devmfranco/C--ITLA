using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresar el primer numero: ");
        double primerNumero = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresar el segundo numero: ");
        double segundoNumero = Convert.ToDouble(Console.ReadLine());

        if (primerNumero > segundoNumero)
        {
            double suma = primerNumero + segundoNumero;
            double resta = primerNumero - segundoNumero;
            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La diferencia es: " + resta);
        }
        else
        {
            double producto = primerNumero * segundoNumero;
            if (primerNumero != 0)  
            {
                double division = primerNumero / segundoNumero;
                Console.WriteLine("El producto es: " + producto);
                Console.WriteLine("La división es: " + division);
            }
            else
            {
                Console.WriteLine("No es posible dividir entre cero");
            }
        }
    }
}
