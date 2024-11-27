using System;

internal class Program
{
    public static void Main(string[] args)
    {
        const string FILE = "ALGUNSPRIMERS.txt";
        StreamReader file = new StreamReader(FILE);
        string linea = file.ReadLine();

        int numero = 0;
        int divisor = 2;

        bool esPrimer;

        while (linea != null)
        {
            numero = int.Parse(linea);
            esPrimer = EsPrimer(numero);
           
           if(esPrimer){Console.WriteLine($"{numero} es primer");}
           else {Console.WriteLine($"{numero} No es primer");}
           linea = file.ReadLine();
        }
    }
    public static bool EsPrimer(int n)
    {
        bool primer = true;
        int divisors = 2;

        while (divisors <= Math.Sqrt(n))
        {
            if (n % divisors == 0)
            {
                primer = false;
            }
            divisors++;
        }
        return primer;
    }
}