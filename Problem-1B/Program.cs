using System;

internal class Program
{/// <summary>
/// Programa que donat un numero per teclat demana altres numeros per compararlos i acabar el programa.
/// </summary>
/// <param name="args"></param>
    public static void Main(string[] args)
    {
        Console.WriteLine("Introdueix el primer valor per comparar-lo");
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = 0;
        bool valorsIguals = false;
        while(!(valorsIguals || valor2 == -9999))
        {
            Console.Write("Introdueix un valor (-9999) per acabar el programa --> ");
            valor2= int.Parse(Console.ReadLine());
            valorsIguals = valor1 == valor2;
        }
        if(valorsIguals)Console.WriteLine("Valors igual introduit.. fi del programa");
        else Console.WriteLine("Has introduit -9999 acabant el programa...");
    }
}