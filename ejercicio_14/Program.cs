using System;

// 1.	Leer 4 números enteros, calcular la suma e informar el resultado

namespace EjerciciosCSharp
{
    class Program
    {
       static void Main(string[] args)
        {
            int per1 = 0;
            int per2 = 0;
            Console.WriteLine("ingrese el año de nacimiento de la primer persona");
            per1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el año de nacimiento de la segunda persona");
            per2 = int.Parse(Console.ReadLine());
            if(per1 < per2){
                Console.WriteLine("la persona 1 pasa primero");
            }else if(per2 < per1){
                Console.WriteLine("la persona 2 pasa primero");
            }else{
                Console.WriteLine("ingrese el mes de nacimiento de la primer persona");
                per1 = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese el mes de nacimiento de la segunda persona");
                per2 = int.Parse(Console.ReadLine());
                if(per1 < per2){
                Console.WriteLine("la persona 1 pasa primero");
                }else if(per2 < per1){
                    Console.WriteLine("la persona 2 pasa primero");
                }else{
                    Console.WriteLine("ingrese el dia de nacimiento de la primer persona");
                    per1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("ingrese el dia de nacimiento de la segunda persona");
                    per2 = int.Parse(Console.ReadLine());
                    if(per1 < per2){
                        Console.WriteLine("la persona 1 pasa primero");
                    }else if(per2 < per1){
                        Console.WriteLine("la persona 2 pasa primero");
                    }else{
                        Console.WriteLine("Pasan juntos o no se error");
                    }
                }
            }
        }
    }
}
