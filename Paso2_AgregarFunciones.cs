using System;

class Program
{
    static void Main()
    {
        int cantidad;
        Console.Write("¿Cuántas notas deseas ingresar? ");
        cantidad = int.Parse(Console.ReadLine());

        int[] notas = new int[cantidad];
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingresa la nota " + (i+1) + ": ");
            notas[i] = int.Parse(Console.ReadLine());
        }

        double promedio = 0;
        int maxima = 0, minima = 0;
        CalcularDatos(notas, ref promedio, ref maxima, ref minima);

        int aprobados = ContarAprobados(notas);

        Console.WriteLine("\nNotas ingresadas:");
        foreach (int n in notas)
        {
            Console.WriteLine(n);
        }
    }

    static void CalcularDatos(int[] datos, ref double prom, ref int ma, ref int mi)
    {
        int suma = 0;
        ma = datos[0];
        mi = datos[0];
        foreach (int n in datos)
        {
            suma += n;
            if (n > ma) ma = n;
            if (n < mi) mi = n;
        }
        prom = (double)suma / datos.Length;
    }

    static int ContarAprobados(int[] datos)
    {
        int contador = 0;
        foreach (int n in datos)
        {
            if (n >= 12)
                contador++;
        }
        return contador;
    }
}
