using System;


namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fecha = 00000000;
            Console.WriteLine("ingrese una fecha en el siguiente Formato DDMMAAAA");
            fecha =  int.Parse(Console.ReadLine());
            Console.WriteLine($"El resultado es: {fecha/1000000}/{fecha%1000000/10000}/{fecha%10000}");
        }
    }
}
