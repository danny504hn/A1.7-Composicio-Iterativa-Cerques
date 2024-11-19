using System;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Introdueix una sequencia de numeros i et dire si hi ha algun parell");
        int valor = 0;
        bool esParell = false;
        while(!(valor == -9999 || esParell))
        {
            Console.Write("Introdueix un valor (-9999) per sortir --> ");
            valor = int.Parse(Console.ReadLine());
            if(valor % 2 == 0) esParell = true;
        }
        if(esParell) Console.WriteLine("Has introduit un valor parell sortint...");
        else Console.WriteLine("Fi del programa...");
    }
}