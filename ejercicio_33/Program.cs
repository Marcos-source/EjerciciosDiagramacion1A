using System;

namespace ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;
            int num = 0;
            int max = 0;
                Console.WriteLine("ingrese la cantidad de numeros a ingresar");
                cant =  int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese un numero");
                num =  int.Parse(Console.ReadLine());
                max = num;
            for (int i = 1; i < cant; i++)
            {
                Console.WriteLine("ingrese un numero");
                num =  int.Parse(Console.ReadLine());
                if (num>max)
                {
                    max = num;
                }
            }
            Console.WriteLine($"el numero mas grande es : {max}");
        }
    }
}
