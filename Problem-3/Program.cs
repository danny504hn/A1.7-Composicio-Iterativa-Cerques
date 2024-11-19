using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string NUMEROS = "NUMEROS.txt";
        StreamReader numerosTxt = new StreamReader(NUMEROS);
        string linea = numerosTxt.ReadLine();
        Console.Write("Introdueix un numero i el buscare a l'arxiu --> ");
        int valorUser = int.Parse(Console.ReadLine());
        int valorTxt;
        int contador = 0;   
        bool trobat = false;
        while(!(trobat || linea == null))
        {
            contador++;
            valorTxt = int.Parse(linea);
            linea = numerosTxt.ReadLine();
            trobat = valorTxt == valorUser;
        }
        if(trobat)Console.WriteLine($"{contador}");
        else Console.WriteLine("-1");
    }
}