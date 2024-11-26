using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string FILE = "PLAGA.TXT";
        StreamReader file = new StreamReader(FILE);
        string linea = file.ReadLine();
        int contador = 0;
        int exemplars = 0;
        bool trobat = false;

        while (!trobat && linea != null)
        {
            exemplars = int.Parse(linea);
            
            if (exemplars > 500)
            {
                contador++;
                if (contador == 5) trobat = true;
            }
            else contador = 0;

            linea = file.ReadLine();
        }
        if (trobat) Console.WriteLine($"HI HA PLAGA");
        else Console.WriteLine($"NO HI HA PLAGA");
    }
}