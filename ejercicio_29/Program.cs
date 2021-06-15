using System;

//3.	Dado 1 número con decimales, que representa el lado de un cuadrado se pide informar la superficie del mismo.

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 1;
            double peso = 1;
            int countEdad = 0;
            double maxPeso = -1;
            double minPeso = 300000;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("ingrese la edad de un niño");
                edad =  int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el peso de un niño");
                peso =  int.Parse(Console.ReadLine());
                if (peso > maxPeso)
                {
                    maxPeso = peso;
                }
                if (peso < minPeso)
                {
                    minPeso = peso;
                }
                if (edad > 5)
                {
                    countEdad++;
                }
            }
            Console.WriteLine("cantidad de niños fure del rango de edad : " + countEdad);
            Console.WriteLine("niño con mas peso: " + maxPeso);
            Console.WriteLine("niño con menos peso: " + minPeso);
        }
    }
}
