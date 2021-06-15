using System;

// 1.	Leer 4 números enteros, calcular la suma e informar el resultado

namespace EjerciciosCSharp
{
    class Program
    {
       static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("ingrese un numero a sumar");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero a sumar");
            a = a + int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero a sumar");
            a = a + int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un numero a sumar");
            a = a + int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {a}");
        }
    }
}
