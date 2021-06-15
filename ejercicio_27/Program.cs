using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {  
            int num = 2;
            int acum = 1;
            Console.WriteLine($"{num} elevado a 0 es igual a 1");
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{num} elevado a {i} es igual a {acum *= num}");
                }
        }
    }
}
