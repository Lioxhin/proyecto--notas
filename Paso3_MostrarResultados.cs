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
        int desaprobados = cantidad - aprobados;

        double porcAprobados = (aprobados * 100.0) / cantidad;
        double porcDesaprobados = (desaprobados * 100.0) / cantidad;

        Console.WriteLine("\n--- Reporte del Salón ---");
        Console.WriteLine("Promedio: " + promedio.ToString("F2"));
        Console.WriteLine("Nota más alta: " + maxima);
        Console.WriteLine("Nota más baja: " + minima);
        Console.WriteLine("Aprobados: " + aprobados + " (" + porcAprobados.ToString("F2") + "%)");
        Console.WriteLine("Desaprobados: " + desaprobados + " (" + porcDesaprobados.ToString("F2") + "%)");
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
