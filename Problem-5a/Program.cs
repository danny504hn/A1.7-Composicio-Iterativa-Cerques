using System;

internal class Program
{
    public static void Main(string[] args)
    {
        int numero;
        int divisors = 2;
        bool esPrimer = true;
        Console.Write("Introdueix un numero --> ");
        numero = int.Parse(Console.ReadLine());

        while (divisors <= Math.Sqrt(numero))
        {
            if (numero % divisors == 0)
            {
                esPrimer = false;
            }
            divisors++;
        }
        if (esPrimer) Console.WriteLine("Es primer");
        else Console.WriteLine("no es primer");
    }
}