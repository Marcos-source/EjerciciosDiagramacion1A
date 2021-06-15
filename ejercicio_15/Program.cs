using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            Console.WriteLine("ingrese el primer numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            num2 = int.Parse(Console.ReadLine());
            if (num1>num2)
            {
                Console.WriteLine($"[{num1} ,{num2}]");
            }else if(num2>num1){
                Console.WriteLine($"[{num2},{num1}]");
            }else{
                Console.WriteLine("los numeros son iguales");
            }
        }
    }
}
