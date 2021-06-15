using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int countPar = 0;
            int acum = 0;
            Console.WriteLine("ingrese un numero");
            num = int.Parse(Console.ReadLine());
            if(num>1500){
                Console.WriteLine("el numero no debe ser superior a 1500");
            }else{
                for (int i = 1; i <= num; i++)
                {
                    if (i%2 == 0)
                    {
                        acum += i;
                        countPar++;
                    }
                }
                Console.WriteLine($"suma de los numero pares : {acum}, cantidad de numeros pares : {countPar}, promedio : {acum/countPar}");
            }
        }
    }
}
