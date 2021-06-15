using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantCars = 0;
            double carValue = 0;

            Console.WriteLine("ingrese la cantidad de autos vendidos");
            cantCars =  int.Parse(Console.ReadLine());
            for (int i = 0; i < cantCars; i++)
            {
                Console.WriteLine("ingrese el precio del auto");
                carValue = carValue + (double.Parse(Console.ReadLine())*0.05 + 200);
            }
            Console.WriteLine($"Sueldo a fin de Mes : {carValue + 5500}");
        }
    }
}
