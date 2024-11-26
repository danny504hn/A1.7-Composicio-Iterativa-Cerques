using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string FILE ="NOPERILL.TXT";       
        StreamReader file = new StreamReader(FILE);
        string linea = file.ReadLine();
        int silurs;
        int suma = 0;
        bool trobat = false;
        while(!trobat && linea!=null)
        {
            silurs = int.Parse(linea);
            if(silurs !=0)
            {
                suma+=silurs;
            }else if(suma <10)
            {
                trobat = true;
            }
            linea = file.ReadLine();
        }
        if(trobat) Console.WriteLine("EN PERILL");
        else Console.WriteLine("NO ESTA EN PERILL");
    }
}