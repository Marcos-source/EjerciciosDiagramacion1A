using System;

//3.	Dado 1 número con decimales, que representa el lado de un cuadrado se pide informar la superficie del mismo.

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 1;
            Console.WriteLine("ingrese el lado de un cuadrado");
            area =  double.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {area * area}");
        }
    }
}
