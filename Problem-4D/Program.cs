﻿using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string PERFECTE = "PERFECTES.txt";
        StreamReader perfectesTxt = new StreamReader(PERFECTE);
        string linea = perfectesTxt.ReadLine();
        int valor;
        bool esPerf = false;
        while (!(esPerf||linea == null))
        {
            valor = int.Parse(linea);
            esPerf = EsPerfecte(valor);
            if(esPerf) esPerf = true;
            else linea = perfectesTxt.ReadLine();       
        }
        if(esPerf) Console.WriteLine("Hi ha un valor perfecte");
        else Console.WriteLine("No hi ha cap valor perfecte");
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