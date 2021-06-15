using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("ingrese un numero positivo");
            num = int.Parse(Console.ReadLine());
            if (num <= 0) {
                Console.WriteLine("el numero no puede ser negativo o 0");
            }else {
                int aux = num;
                for (int i = 1; i < aux; i++)
                {
                    num = num * i;
                }
                Console.WriteLine(num);
            }
        }
    }
}
