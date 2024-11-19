using System;
using System.Text.RegularExpressions;

internal class Program
{
    public static void Main(string[] args)
    {
        const string NUMEROS = "NUMEROS.txt";
        StreamReader numerosTxt = new StreamReader(NUMEROS);
        string linea = numerosTxt.ReadLine();
        bool esParell = false;
        int valor;
        int contador = 0;
        while(!(esParell || linea == null))
        {
            contador++;
            valor = int.Parse(linea);
            linea = numerosTxt.ReadLine();
            if(valor %2 ==0)
            {
                esParell = true;
            }
        }
        if(esParell) Console.WriteLine($"Numero parell trobat a la linea {contador}");
        else Console.WriteLine("Cap numero es parell");
    }
}