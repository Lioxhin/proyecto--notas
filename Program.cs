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
            Console.Write("Ingresa la nota " + (i + 1) + ": ");
            notas[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nLas notas ingresadas son:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("Nota " + (i + 1) + ": " + notas[i]);
        }
    }
}