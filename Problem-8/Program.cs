internal class Program
{
    public static void Main(string[] args)
    {
        const string FILE = "COMPLEIX.txt";
        StreamReader file = new StreamReader(FILE);

        string linea = file.ReadLine();
        int suma = int.Parse(file.ReadLine());

        int valor = 0;
        bool trobat = false; 

        while (!trobat && linea != null)
        {
            valor = int.Parse(linea);

            if (valor == suma)
            {
                linea = file.ReadLine(); 
                suma += valor;
            }
            else
            trobat = valor != suma;
        }
        if (trobat) Console.WriteLine("NO");
        else Console.WriteLine("SI");
    }
}