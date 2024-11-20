﻿using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string PERFECTE = "PERFECTES.txt";
        StreamReader perfectesTxt = new StreamReader(PERFECTE);
        string linea;
        int valor = 0;

        while ((linea = perfectesTxt.ReadLine()) != null)
        {
            valor = int.Parse(linea);
            bool esPerf = EsPerfecte(valor);
            if (esPerf) Console.WriteLine($"{valor} Es perfecte");
            else Console.WriteLine($"{valor} No es perfecte");
        }

    }
    public static bool EsPerfecte(int n)
    {
        int suma = 0;
        int contador = 0;
        while (contador < n / 2)
        {
            contador++;
            if (n % contador == 0) suma += contador;
        }
        return suma == n;
    }
}
