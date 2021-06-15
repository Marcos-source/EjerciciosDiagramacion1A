using System;

// 2.	Dados 2 números enteros, que representan los lados de un rectángulo se pide informar la superficie del mismo.

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio = 1;
            Console.WriteLine("Ingrese un año para determinar si es bisiesto");
            anio = int.Parse(Console.ReadLine());
            if ((anio % 400 == 0) || (anio % 4 == 0 && anio % 100 != 0))
            {
                Console.WriteLine($"el año {anio} es bisiesto");

            }else{
                Console.WriteLine($"el año {anio} no es bisiesto");
            }
        }
    }
}
