using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string PERFECTE = "PERFECTES.txt";
        StreamReader perfectesTxt = new StreamReader(PERFECTE);
        string linea;
        int valor = 0;
        bool esPerf = false;
        while ((linea = perfectesTxt.ReadLine()) != null)
        {
            valor = int.Parse(linea);
            esPerf = EsPerfecte(valor);
            if (esPerf) Console.WriteLine($"{valor} Es perfecte");
            else Console.WriteLine($"{valor} No es perfecte");
        }

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
