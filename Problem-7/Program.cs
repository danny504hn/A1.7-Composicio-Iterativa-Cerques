using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string FILE ="TROBAT.TXT";
        StreamReader file = new StreamReader(FILE);
        string linea = file.ReadLine();

        int contador = 0;
        int dorsal;
        bool trobat = false;

        while(!trobat && linea!=null)
        {
            contador++;
            dorsal = int.Parse(linea);
            if(dorsal == 231)
            {
                trobat = true;
            }
            linea = file.ReadLine();
        }
        if(trobat) Console.WriteLine($"Dorsal 231 arriba en la posicio {contador}");
        else Console.WriteLine("Dorsal 231 s'ha perdut");
    }
}