using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int max = 0;
            int counter = 2147483647;
                Console.WriteLine("ingrese un numero");
                num =  int.Parse(Console.ReadLine());
                max = num;
            for (int i = 1; i < counter; i++)
            {
                Console.WriteLine("ingrese un numero");
                num =  int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    i = counter;
                }
                if (num != 0 && num>max)
                {
                    max = num;
                }
                
            }
            Console.WriteLine($"el numero mas grande es : {max}");
        }
    }
}
