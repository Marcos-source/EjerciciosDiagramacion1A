using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantA = 0;
            int a = 0;
            int acum = 0;
            string nombre = "";
            float promedio = 0;
            Console.WriteLine("Ingre la cantidad de alumnos");
            cantA = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantA; i++) {
                Console.WriteLine("Datos del alumno numero: "+ (i+1) );
                Console.WriteLine("Ingre el nombre del alumno");
                nombre = (Console.ReadLine());
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingre la nota");
                    a = int.Parse(Console.ReadLine());
                    acum+=a;  
                }
                promedio = acum/4;
                Console.WriteLine($"el promedio de la nota del alumno {nombre} es {promedio}");
            }
        }
    }
}
