using System;
using System.Diagnostics.Contracts;

internal class Program
{
    public static void Main(string[] args)
    {
        int n = 28;
        bool esPerf = EsPerfecte(n);
        Console.Write(esPerf);
    }
    public static bool EsPerfecte(int n)
    {
        int suma = 0;
        int contador= 0;
        while(contador < n/2)
        {
            contador++;
            if(n % contador == 0) suma+=contador;
        }
        return suma == n;
    }
}