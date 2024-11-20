using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string PERFECTE = "PERFECTES.txt";
        StreamReader perfectesTxt = new StreamReader(PERFECTE);
        string linea;
        int valor = 0;
        while((linea = perfectesTxt.ReadLine()) != null)
        {
            valor = int.Parse(linea);
            int suma = 0;
            for(int i = 1; i <= valor / 2; i++)
            {
                if(valor % i == 0) suma+=i;
            }

            if(valor == suma) Console.WriteLine($"{valor} Es perfecte");
            else Console.WriteLine($"{valor} No es perfecte");

            
            
        }
       
    }
}
