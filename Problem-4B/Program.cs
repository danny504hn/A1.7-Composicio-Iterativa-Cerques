using System;
using System.Diagnostics.Contracts;

internal class Program
{
    public static void Main(string[] args)
    {
        int n = 28;
        bool esPerf = EsPerfecte(n);
        if (esPerf) Console.WriteLine("El numero es perfecte");
        else Console.WriteLine("El numero no es perfecte");
    }
    public static bool EsPerfecte(int n)
    {
        int divisorMaxim = n / 2;
        int suma = 0;
        int contador = 0;
        while (contador < divisorMaxim && suma < n)
        {
            contador++;
            if (n % contador == 0) suma += contador;
        }
        return suma == n;
    }
}