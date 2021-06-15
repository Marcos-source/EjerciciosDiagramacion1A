using System;

// 2.	Dados 2 números enteros, que representan los lados de un rectángulo se pide informar la superficie del mismo.

namespace ejercicio_2
{
    class Program
    {
        private const string Value = "ingrese el ancho de un rectangulo";

        static void Main(string[] args)
        {
            int area = 1;
            Console.WriteLine(value: Value);
            area = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el alto de un rectangulo");
            area = area * int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {area}");
        }
    }
}
