using System;

//3.	Dado 1 número con decimales, que representa el lado de un cuadrado se pide informar la superficie del mismo.

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double parcial = 0;
            double trabajosPracticos = 0;
            double examenFinal = 0;
            Console.WriteLine("ingrese la nota del parcial del 0 al 10");
            parcial =  double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la nota del tp del 0 al 10");
            trabajosPracticos =  double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la nota del integrador del 0 al 10");
            examenFinal =  double.Parse(Console.ReadLine());
            Console.WriteLine($"promedio final : { parcial * 0.3 + trabajosPracticos * 0.2 + examenFinal * 0.5 }");
        }
    }
}
