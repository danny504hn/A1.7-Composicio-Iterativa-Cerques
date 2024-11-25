<<<<<<< HEAD
﻿using System.Security.Cryptography.X509Certificates;

internal class Program
{/// <summary>
/// Programa per donat un tiquet de supermercat retorna, si la compra es reica en colesterol, si es fa la compra i dir quien es l'import total, si hi ha un producte ric amb colesterol mostrar quin es
/// si no apareix cap mostra COMPRA SANA
/// </summary>
/// <param name="args"></param>
    public static void Main(string[] args)
    {
        const string FILE = "TIQUET.txt";
        StreamReader tiquet = new StreamReader(FILE);
        string linea = tiquet.ReadLine();

        bool trobat = false; // si hi ha més d'un producte amb colesterol es rebutja la compra
        int pAmbColesterol = 0; //quants productes amb colesterol trobem

        string producte; // nom del producte
        int unitat; //quantit D'unitat
        double importFinal = 0; //Preu final del tiquet
        double preuUnitari;  //Preu per unitat
        
        string pColesterol = ""; //Producte amb colesterol

        while(!trobat && linea!=null)
        {
            producte = linea;
            unitat = int.Parse(tiquet.ReadLine());
            preuUnitari = double.Parse(tiquet.ReadLine());

            if(producte.Contains("PIZZ") || producte.Contains("EMBOTIT"))
            {
                pAmbColesterol++;
                pColesterol = linea;
            }
            if(pAmbColesterol <=1)
            {
                importFinal += unitat * preuUnitari;
            }
            else if (pAmbColesterol == 2) trobat = true;
            linea = tiquet.ReadLine();
        }

        if(trobat) Console.WriteLine("Compra rebutjada");
        else if(pAmbColesterol == 1)Console.WriteLine($"Compra rica en colesterol {pColesterol}, preu {importFinal:F2}");
        else Console.WriteLine($"COMPRA SANA, preu total {importFinal:F2}");
=======
﻿using System;

internal class Program
{
    public static void Main(string[] args)
    {
               
>>>>>>> 218f099b898d08b49f49729d2a90c05e0f87be8f
    }
}