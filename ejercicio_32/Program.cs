using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // 13.	Leer dos fechas en formato DDMMAAAA. Informar cuál de ellas es la menor  o si son iguales.
            int num = 0;
            int acum = 0;
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());
            acum = num;
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("ingrese un numero");
                num = int.Parse(Console.ReadLine());
                if (num>acum)
                {
                    acum = num;
                }
                if (num == 0)
                {
                    i = 499;
                }
            }
            Console.WriteLine($"el numero mas grande es : {acum}");
        }
    }
}
