using System;

internal class Program
{
    public static void Main(string[] args)
    {
        double numero;
        double divisors = 2;
        bool esPrimer = true;
        Console.Write("Introdueix un numero --> ");
        numero = double.Parse(Console.ReadLine());
        if (numero <= 1) esPrimer = true;
        else
        {
            while (divisors <= Math.Sqrt(numero))
            {
                if (numero % divisors == 0)
                {
                    esPrimer = false;
                }
                divisors++;
            }
        }
        if (esPrimer) Console.WriteLine("Es primer");
        else Console.WriteLine("no es primer");
    }
}