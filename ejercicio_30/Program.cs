using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int acum = 0;
            Console.WriteLine("Ingre se el numero a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingre se el numero b");
            b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++) {
             acum+=a;  
            }
            Console.WriteLine($"{a} por {b} es igual a {acum}");
        }
    }
}
