using System;

namespace EjerciciosCSharp
{
    class Program
    {
       static void Main(string[] args)
        {
            int num = 0;
            int cant = 6;
            // Console.WriteLine("ingrese un numero a sumar");
            // a = int.Parse(Console.ReadLine());
            // Console.WriteLine("ingrese un numero a sumar");
            // a = a + int.Parse(Console.ReadLine());
            // Console.WriteLine("ingrese un numero a sumar");
            // a = a + int.Parse(Console.ReadLine());
            // Console.WriteLine("ingrese un numero a sumar");
            // a = a + int.Parse(Console.ReadLine());
            // Console.WriteLine($"El resultado es: {a}");
            for (int i = 0; i < cant; i++) {
                Console.WriteLine("ingrese un numero a sumar");
                num += int.Parse(Console.ReadLine());
            }
            float prom = (float)num/cant;
            Console.WriteLine($"el promedio es : {prom}");
        }
    }
}
