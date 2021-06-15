using System;

namespace ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string apellido = " ";
            int sueldo = 0;
            int anti = 0;
            Console.WriteLine("ingrese su appellido");
            apellido = Console.ReadLine();
            Console.WriteLine("ingrese sueldo");
            sueldo = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese su antiguedad");
            anti = int.Parse(Console.ReadLine());
            if(anti>=9){
                Console.WriteLine($"Su sueldo es : {sueldo + (sueldo*0.4)}$");
            }else{
                Console.WriteLine($"Su sueldo es : {sueldo}$");
            }
        }
    }
}
