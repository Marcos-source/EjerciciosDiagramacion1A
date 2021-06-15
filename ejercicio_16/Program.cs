using System;

//3.	Dado 1 número con decimales, que representa el lado de un cuadrado se pide informar la superficie del mismo.

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int min = 999999999;
            for (int i = 0; i < 3; i++) {
                Console.WriteLine($"ingrese el numero: {i+1}");
                num1 =  int.Parse(Console.ReadLine());
                if(num1 < min) {
                    min = num1;
                }
            }
            Console.WriteLine($"El menor es : {min}");
        }
    }
}
