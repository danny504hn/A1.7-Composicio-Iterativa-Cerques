using System;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Introdueix un numero --> ");      
        int num = int.Parse(Console.ReadLine());
        int suma = 0;
        int contador = 0;
        while (contador <= num/2)
        {
            contador++;
            if (num % contador == 0) 
            {
            suma += contador;
            Console.WriteLine($"{suma}  {contador}");
            }
        }
        if (num == suma) Console.WriteLine("Es perfecte");
        else Console.WriteLine("No es perfecte");
    }
}