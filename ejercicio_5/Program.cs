using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  5.	Se  necesita calcular la superficie de un triángulo, y se dispone 
            //  solamente de los valores de su base y altura. Definir también que tipo de valor es aconsejable para las variables con la información que se tiene.
            //  **No se podrá usar valores fijos en las fórmulas del algoritmo. Solo variables y/o constantes.**

            int iAltura = 0;
            int iBase = 0;
            const int iDos = 2;
            Console.WriteLine("ingrese la base");
            iBase = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura");
            iAltura = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {(iBase * iAltura )/ iDos}");
        }
    }
}
