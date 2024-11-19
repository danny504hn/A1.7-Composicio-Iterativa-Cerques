using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string NUMEROS = "NUMEROS.TXT";
        StreamReader numerosTxt = new StreamReader(NUMEROS);
        string linea = numerosTxt.ReadLine(); //Primera linea
        int valor1 = int.Parse(linea);
        int valor2 = 0;
        int contador = 1; //comença amb 1 per que el valor de la linea 1 ja esta comptat
        bool valorsIguals = false;
        while(!(valorsIguals || linea ==null))
        {
            contador++;
            valor2 = int.Parse(numerosTxt.ReadLine()); // llegeix el següent valor  a partir de la linea 2
            valorsIguals = valor1 == valor2; //compara el valor de la PRIMERA linea amb les seguents
        }
        if(valorsIguals) Console.WriteLine($"Els valors son iguals a la linea {contador }");
        else Console.WriteLine("El primer valor no es repeteix");
    }
}