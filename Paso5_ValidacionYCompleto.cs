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
            int nota;

            do
            {
                Console.Write("Ingresa la nota " + (i + 1) + ": ");
                nota = int.Parse(Console.ReadLine());

                if (nota < 0 || nota > 20)
                {
                    Console.WriteLine("Nota inválida, ingresa entre 0 y 20.");
                }

            } while (nota < 0 || nota > 20);

            notas[i] = nota;
        }

        double promedio = 0;
        int maxima = 0;
        int minima = 0;

        CalcularDatos(notas, ref promedio, ref maxima, ref minima);

        int aprobados = ContarAprobados(notas);
        int desaprobados = cantidad - aprobados;

        double porcentajeAprobados = (aprobados * 100.0) / cantidad;
        double porcentajeDesaprobados = (desaprobados * 100.0) / cantidad;

        Console.WriteLine("\n--- Reporte del Salón ---");
        Console.Write("\nNotas ingresadas: [");

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write(notas[i]);
            if (i < notas.Length - 1) Console.Write(", ");
        }

        Console.WriteLine("]");
        Console.WriteLine("\nPromedio : " + promedio.ToString("F2"));
        Console.WriteLine("Nota máxima : " + maxima);
        Console.WriteLine("Nota mínima : " + minima);

        Console.WriteLine("\nAprobados : " + aprobados + " (" + porcentajeAprobados.ToString("F2") + "%)");
        Console.WriteLine("Desaprobados : " + desaprobados + " (" + porcentajeDesaprobados.ToString("F2") + "%)");

        if (porcentajeDesaprobados > 75)
        {
            Console.WriteLine("\nALERTA: Más del 75% desaprobó.");
        }
    }

    static void CalcularDatos(int[] notas, ref double promedio, ref int maxima, ref int minima)
    {
        int suma = 0;
        maxima = notas[0];
        minima = notas[0];

        for (int i = 0; i < notas.Length; i++)
        {
            suma += notas[i];
            if (notas[i] > maxima) maxima = notas[i];
            if (notas[i] < minima) minima = notas[i];
        }

        promedio = (double)suma / notas.Length;
    }

    static int ContarAprobados(int[] notas)
    {
        int contador = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            if (notas[i] >= 12)
                contador++;
        }
        return contador;
    }
}
