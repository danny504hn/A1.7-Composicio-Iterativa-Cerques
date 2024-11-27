using System;

internal class Program
{
    public static void Main(string[] args)
    {
        int numero;
        bool esPrimer = true;
        Console.Write("Introdueix un numero --> ");
        numero = int.Parse(Console.ReadLine());
        esPrimer = EsPrimer(numero);

        if (esPrimer) Console.WriteLine("Es primer");
        else Console.WriteLine("no es primer");
    }
    public static bool EsPrimer(int n)
    {
        bool primer = true;
        int divisors = 2;

        while (divisors <= Math.Sqrt(n))
        {
            if (n % divisors == 0)
            {
                primer = false;
            }
            divisors++;
        }
        return primer;
    }
}