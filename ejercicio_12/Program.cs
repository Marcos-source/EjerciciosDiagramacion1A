using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1 = 0;
            double num2 = 0;
            Console.WriteLine("ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            if (num1 / num2 < 1 || num2 == 0) {
                Console.WriteLine("Error");
            }else{
                Console.WriteLine($"El resultado es : {num1/num2}");
            }
        }
    }
}
