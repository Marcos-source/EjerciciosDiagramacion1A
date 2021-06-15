using System;


namespace ejercicio_2
{
    class Program
    {

        static void Main(string[] args)
        {
            float numTotal = 1;
            float numParcial = 1;
            Console.WriteLine("ingrese el numero total");
            numTotal = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero parcial");
            numParcial = int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {100*(numParcial/numTotal)}%");
        }
    }
}
